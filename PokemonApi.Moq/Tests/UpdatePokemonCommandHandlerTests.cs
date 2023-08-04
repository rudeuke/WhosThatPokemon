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
    public class UpdatePokemonCommandHandlerTests
    {
        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;

        public UpdatePokemonCommandHandlerTests()
        {
            _pokemonRepositoryMock = new();
            _mapperMock = new();
        }

        [Fact]
        public async Task Handle_ShouldReturnPokemon_AfterPokemonUpdate()
        {
            //Arrange
            var pokemonId = 1;
            var pokemonName = "Pikachu";
            var pokemon = new Pokemon { Id = pokemonId, Name = pokemonName };
            var newPokemonName = "Squirtle";
            var newPokemonTypes = new List<string> { "Water" };
            var pokemonTypeWater = new WhosThatPokemon.Models.Type { PokeType = TypeEnum.Water };
            var updatedPokemonDto = new UpdatePokemonDto { Id = pokemonId, Name = newPokemonName, PokemonTypes = newPokemonTypes };
            var expectedResponse = new ServiceResponse<GetPokemonDto>
            {
                Data = new GetPokemonDto { Id = updatedPokemonDto.Id, Name = updatedPokemonDto.Name, PokemonTypes = updatedPokemonDto.PokemonTypes },
                Success = true,
                StatusCode = HttpStatusCode.OK
            };

            var query = new UpdatePokemonCommand(updatedPokemonDto);

            _pokemonRepositoryMock.Setup(
                x => x.GetById(pokemonId))
                .ReturnsAsync(pokemon);

            _pokemonRepositoryMock.Setup(
                x => x.Update(pokemon));

            _mapperMock.Setup(
                x=> x.Map<Pokemon>(updatedPokemonDto))
                .Returns(new Pokemon { Name = updatedPokemonDto.Name, PokemonTypes = { pokemonTypeWater } });

            _mapperMock.Setup(
                x => x.Map<GetPokemonDto>(pokemon))
                .Returns(expectedResponse.Data);

            var handler = new UpdatePokemonCommandHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            //Act
            var result = await handler.Handle(query, default);

            //Assert
            result.Should().BeOfType<ServiceResponse<GetPokemonDto>>();
            result.Success.Should().Be(expectedResponse.Success);
            result.StatusCode.Should().Be(expectedResponse.StatusCode);
            result.Data.Should().BeOfType<GetPokemonDto>();
            result.Data.Should().NotBeNull();
            result.Data.Id.Should().Be(expectedResponse.Data.Id);
            result.Data.Name.Should().Be(expectedResponse.Data.Name);
            result.Data.PokemonTypes.Should().BeEquivalentTo(expectedResponse.Data.PokemonTypes);
        }

        [Fact]
        public async Task Handle_ShouldThrowException_WhenPokemonDoesNotExist()
        {
            // Arrange
            var pokemonId = It.IsAny<int>();
            var newPokemonName = "Squirtle";
            var newPokemonTypes = new List<string> { "Water" };
            var updatedPokemonDto = new UpdatePokemonDto { Id = pokemonId, Name = newPokemonName, PokemonTypes = newPokemonTypes };
            var query = new UpdatePokemonCommand(updatedPokemonDto);

            _pokemonRepositoryMock.Setup(
                x => x.GetById(It.IsAny<int>()))
                .ReturnsAsync(() => null);

            var handler = new UpdatePokemonCommandHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            // Act

            // Assert
            var ex = await Assert.ThrowsAsync<ExceptionWithStatusCode>(async () => await handler.Handle(query, default));
            ex.HttpStatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
