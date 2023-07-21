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

            try
            {
                var newPokemon = _mapper.Map<Pokemon>(newPokemonDto);
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

            try
            {
                var pokemon = await _db.Pokemons.FindAsync(id);

                if (pokemon == null)
                {
                    throw new Exception("Pokemon not found.");
                }

                serviceResponse.Data = _mapper.Map<GetPokemonDetailsDto>(pokemon);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPokemonDto>> UpdatePokemon(UpdatePokemonDto updatedPokemonDto)
        {
            var serviceResponse = new ServiceResponse<GetPokemonDto>();

            try
            {
                var pokemon = await _db.Pokemons.FindAsync(updatedPokemonDto.Id);

                if (pokemon == null)
                {
                    throw new Exception("Pokemon not found.");
                }

                var updatedPokemon = _mapper.Map<Pokemon>(updatedPokemonDto);
                pokemon.OriginalId = updatedPokemon.OriginalId;
                pokemon.Name = updatedPokemon.Name;
                pokemon.ImageUrl = updatedPokemon.ImageUrl;
                pokemon.SilhouetteUrl = updatedPokemon.SilhouetteUrl;
                pokemon.PokemonTypes = updatedPokemon.PokemonTypes;

                await _db.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<GetPokemonDto>(pokemon);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
                return serviceResponse;
            }

            return serviceResponse;
        }
    }
}
