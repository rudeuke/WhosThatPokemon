using WhosThatPokemon.Commands;
using WhosThatPokemon.Data.Repositories;

namespace WhosThatPokemon.Handlers.CommandHandlers
{
    public class AddPokemonCommandHandler : IRequestHandler<AddPokemonCommand, ServiceResponse<List<GetPokemonDto>>>
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly IMapper _mapper;

        public AddPokemonCommandHandler(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            _pokemonRepository = pokemonRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> Handle(AddPokemonCommand request, CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();

            var newPokemon = _mapper.Map<Pokemon>(request.NewPokemonDto);

            await _pokemonRepository.Add(newPokemon);

            var pokemons = await _pokemonRepository.GetAll();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            serviceResponse.Message = "New pokemon added successfully";
            return serviceResponse;
        }
    }
}
