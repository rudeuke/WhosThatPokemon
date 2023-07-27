using AutoMapper;
using FluentAssertions;
using Moq;
using System.Net;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Dtos.Pokemon;
using WhosThatPokemon.Handlers.QueryHandlers;
using WhosThatPokemon.Models;
using WhosThatPokemon.Queries;
using WhosThatPokemon.Services.Response;

namespace PokemonApi.Moq.Tests
{
    public class GetAllPokemonsQueryHandlerTests
    {
        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;

        public GetAllPokemonsQueryHandlerTests()
        {
            _pokemonRepositoryMock = new();
            _mapperMock = new();
        }

        [Fact]
        public async Task Handle_ShouldReturnListOfPokemons_WhenPokemonsExist()
        {
            // Arrange
            var pokemonId = 1;
            var pokemonName = "Pikachu";
            var pokemon = new Pokemon { Id = pokemonId, Name = pokemonName };
            var expectedResponse = new ServiceResponse<List<GetPokemonDto>>
            {
                Data = new List<GetPokemonDto> { new GetPokemonDto() { Id = pokemon.Id, Name = pokemon.Name } },
                Success = true,
                StatusCode = HttpStatusCode.OK
            };
            var query = new GetAllPokemonsQuery();

            _pokemonRepositoryMock.Setup(
                x => x.GetAll())
                .ReturnsAsync(new List<Pokemon> { pokemon });

            _mapperMock.Setup(
                x => x.Map<GetPokemonDto>(pokemon))
                .Returns(expectedResponse.Data.First());

            var handler = new GetAllPokemonsQueryHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            // Act
            var result = await handler.Handle(query, default);

            // Assert
            result.Should().BeOfType<ServiceResponse<List<GetPokemonDto>>>();
            result.Success.Should().Be(expectedResponse.Success);
            result.StatusCode.Should().Be(expectedResponse.StatusCode);
            result.Data.Should().BeOfType<List<GetPokemonDto>>();
            result.Data.Should().NotBeNull();
            result.Data.First().Id.Should().Be(expectedResponse.Data.First().Id);
            result.Data.First().Name.Should().Be(expectedResponse.Data.First().Name);
        }

        [Fact]
        public async Task Handle_ShouldReturnEmptyList_WhenPokemonsDoNotExist()
        {
            // Arrange
            var expectedResponse = new ServiceResponse<List<GetPokemonDto>>
            {
                Data = new List<GetPokemonDto>(),
                Success = true,
                StatusCode = HttpStatusCode.OK
            };
            var query = new GetAllPokemonsQuery();

            _pokemonRepositoryMock.Setup(
                x => x.GetAll())
                .ReturnsAsync(new List<Pokemon>());

            var handler = new GetAllPokemonsQueryHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            // Act
            var result = await handler.Handle(query, default);

            // Assert
            result.Should().BeOfType<ServiceResponse<List<GetPokemonDto>>>();
            result.Success.Should().Be(expectedResponse.Success);
            result.StatusCode.Should().Be(expectedResponse.StatusCode);
            result.Data.Should().BeOfType<List<GetPokemonDto>>();
            result.Data.Should().BeEmpty();
        }
    }
}
