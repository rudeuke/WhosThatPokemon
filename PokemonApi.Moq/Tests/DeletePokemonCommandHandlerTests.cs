using AutoMapper;
using FluentAssertions;
using Moq;
using System.Net;
using WhosThatPokemon.Commands;
using WhosThatPokemon.Data.Repositories;
using WhosThatPokemon.Dtos.Pokemon;
using WhosThatPokemon.Exceptions;
using WhosThatPokemon.Handlers.CommandHandlers;
using WhosThatPokemon.Models;
using WhosThatPokemon.Services.Response;

namespace PokemonApi.Moq.Tests
{
    public class DeletePokemonCommandHandlerTests
    {
        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;

        public DeletePokemonCommandHandlerTests()
        {
            _pokemonRepositoryMock = new();
            _mapperMock = new();
        }

        [Fact]
        public async Task Handle_ShouldReturnListOfPokemonsWithoutDeletedPokemon_WhenPokemonDeleted()
        {
            // Arrange
            var pokemonName = "Pikachu";
            var pokemonNameDel = "Charmander";
            var pokemonType = new WhosThatPokemon.Models.Type { PokeType = TypeEnum.Electric };
            var pokemonTypeDel = new WhosThatPokemon.Models.Type { PokeType = TypeEnum.Fire };
            var pokemonToDelete = new Pokemon { Name = pokemonNameDel, PokemonTypes = { pokemonTypeDel } };
            var pokemonToKeep = new Pokemon { Name = pokemonName, PokemonTypes = { pokemonType } };
            var expectedResponse = new ServiceResponse<List<GetPokemonDto>>
            {
                Data = new List<GetPokemonDto> { new GetPokemonDto { Name = pokemonName, PokemonTypes = { "Electric" } } },
                Success = true,
                StatusCode = HttpStatusCode.OK
            };
            var query = new DeletePokemonCommand(pokemonToDelete.Id);

            _pokemonRepositoryMock.Setup(
                x => x.GetById(pokemonToDelete.Id))
                .ReturnsAsync(pokemonToDelete);

            _pokemonRepositoryMock.Setup(
                x => x.Delete(pokemonToDelete));

            _pokemonRepositoryMock.Setup(
                x => x.GetAll())
                .ReturnsAsync(new List<Pokemon> { pokemonToKeep });

            _mapperMock.Setup(
                x => x.Map<GetPokemonDto>(pokemonToKeep))
                .Returns(new GetPokemonDto { Name = pokemonName, PokemonTypes = { "Electric" } });

            var handler = new DeletePokemonCommandHandler(
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
            result.Data.Count.Should().Be(expectedResponse.Data.Count);
            result.Data.First().Id.Should().Be(expectedResponse.Data.First().Id);
            result.Data.First().Name.Should().Be(expectedResponse.Data.First().Name);
            result.Data.First().PokemonTypes.Should().BeEquivalentTo(expectedResponse.Data.First().PokemonTypes);
        }

        [Fact]
        public async Task Handle_ShouldThrowException_WhenPokemonDoesNotExist()
        {
            // Arrange
            var query = new DeletePokemonCommand(It.IsAny<int>());

            _pokemonRepositoryMock.Setup(
                x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);

            var handler = new DeletePokemonCommandHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            // Act
            //var result = await handler.Handle(query, default);

            // Assert
            var ex = await Assert.ThrowsAsync<ExceptionWithStatusCode>(async () => await handler.Handle(query, default));
            ex.HttpStatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
