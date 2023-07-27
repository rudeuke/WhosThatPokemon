//using AutoMapper;
//using Moq;
//using System.Net;
//using WhosThatPokemon.Data.Repositories;
//using WhosThatPokemon.Dtos.Pokemon;
//using WhosThatPokemon.Handlers.QueryHandlers;
//using WhosThatPokemon.Models;
//using WhosThatPokemon.Queries;
//using WhosThatPokemon.Services.Response;

//namespace PokemonApi.Moq.Tests
//{
//    public class AddPokemonCommandHandlerTests
//    {
//        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock;
//        private readonly Mock<IMapper> _mapperMock;

//        public AddPokemonCommandHandlerTests()
//        {
//            _pokemonRepositoryMock = new();
//            _mapperMock = new();
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnPokemon_WhenPokemonExists()
//        {
//            // Arrange
//            var pokemonId = 1;
//            var pokemonName = "Pikachu";
//            var pokemon = new Pokemon { Id = pokemonId, Name = pokemonName };
//            var expectedResponse = new ServiceResponse<GetPokemonDetailsDto>
//            {
//                Data = new GetPokemonDetailsDto { Id = pokemon.Id, Name = pokemon.Name },
//                Success = true,
//                StatusCode = HttpStatusCode.OK
//            };
//            var query = new GetPokemonByIdQuery(pokemonId);

//            _pokemonRepositoryMock.Setup(
//                x => x.GetById(pokemonId))
//                .ReturnsAsync(pokemon);

//            _mapperMock.Setup(
//                x => x.Map<GetPokemonDetailsDto>(pokemon))
//                .Returns(expectedResponse.Data);

//            var handler = new GetPokemonByIdQueryHandler(
//                _pokemonRepositoryMock.Object,
//                _mapperMock.Object);

//            // Act
//            var result = await handler.Handle(query, default);

//            // Assert
//            result.Should().BeOfType<ServiceResponse<GetPokemonDetailsDto>>();
//            result.Success.Should().Be(expectedResponse.Success);
//            result.StatusCode.Should().Be(expectedResponse.StatusCode);
//            result.Data.Should().BeOfType<GetPokemonDetailsDto>();
//            result.Data.Should().NotBeNull();
//            result.Data.Id.Should().Be(expectedResponse.Data.Id);
//            result.Data.Name.Should().Be(expectedResponse.Data.Name);
//        }
//    }
//}
