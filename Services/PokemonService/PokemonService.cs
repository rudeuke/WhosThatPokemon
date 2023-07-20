using Microsoft.EntityFrameworkCore;

namespace WhosThatPokemon.Services.PokemonService
{
    public class PokemonService : IPokemonService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PokemonService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> AddPokemon(AddPokemonDto newPokemonDto)
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();
            var newPokemon = _mapper.Map<Pokemon>(newPokemonDto);
            _db.Pokemons.Add(newPokemon);
            await _db.SaveChangesAsync();
            var pokemons = await _db.Pokemons.ToListAsync();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPokemonDto>>> GetAllPokemons()
        {
            var serviceResponse = new ServiceResponse<List<GetPokemonDto>>();
            var pokemons = await _db.Pokemons.ToListAsync();
            serviceResponse.Data = pokemons.Select(p => _mapper.Map<GetPokemonDto>(p)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPokemonDetailsDto>> GetPokemonById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDetailsDto>();
            var pokemon = await _db.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Pokemon not found.";
                return serviceResponse;
            }
            serviceResponse.Data = _mapper.Map<GetPokemonDetailsDto>(pokemon);
            return serviceResponse;
        }
    }
}
