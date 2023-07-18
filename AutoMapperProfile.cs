using WhosThatPokemon.Data;

namespace WhosThatPokemon
{
    public class AutoMapperProfile : Profile
    {
        private readonly ApplicationDbContext _db;

        public AutoMapperProfile(ApplicationDbContext db)
        {
            _db = db;

            CreateMap<Pokemon, GetPokemonDto>();
            CreateMap<Pokemon, GetPokemonDetailsDto>();
            CreateMap<Pokemon, string>().ConvertUsing(src => src.Name.ToString());
            CreateMap<AddPokemonDto, Pokemon>()
                .ForMember(dest => dest.PokemonTypes, opt => opt.MapFrom(src => MapPokemonTypes(src.PokemonTypes)));
            CreateMap<Models.Type, GetTypeDetailsDto>();
            CreateMap<Models.Type, string>().ConvertUsing(src => src.PokeType.ToString());
        }

        private List<Models.Type> MapPokemonTypes(List<string> pokemonTypes)
        {
            var typesInDb = _db.Types.ToList();
            List<Models.Type> typesConverted = new();

            foreach (var type in pokemonTypes)
            {
                var typeInDb = typesInDb.FirstOrDefault(t => t.PokeType.ToString() == type);
                if (typeInDb != null)
                {
                    typesConverted.Add(typeInDb);
                }
                else
                {
                    throw new Exception($"Type {type} not found.");
                }
            }

            return typesConverted;
        }   
    }
}
