using Microsoft.EntityFrameworkCore;
using WhosThatPokemon.Commands;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class AddPokemonCommandHandler : IRequestHandler<AddPokemonCommand, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AddPokemonCommandHandler(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(AddPokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();

            try
            {
                var newPokemon = _mapper.Map<Pokemon>(request.NewPokemonDto);
                _db.Pokemons.Add(newPokemon);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }

            var pokemons = await _db.Pokemons.ToListAsync();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            return serviceResponse;
        }
    }
}
