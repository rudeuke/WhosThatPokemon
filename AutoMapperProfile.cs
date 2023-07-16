namespace WhosThatPokemon
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pokemon, GetPokemonDto>();
            CreateMap<Models.Type, GetTypeDto>();
        }
    }
}
