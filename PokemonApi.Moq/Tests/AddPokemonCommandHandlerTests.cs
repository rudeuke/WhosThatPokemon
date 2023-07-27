using AutoMapper;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
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
    public class AddPokemonCommandHandlerTests
    {
        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<IValidator<AddPokemonCommand>> _validatorMock;

        public AddPokemonCommandHandlerTests()
        {
            _pokemonRepositoryMock = new();
            _mapperMock = new();
            _validatorMock = new();
        }

        [Fact]
        public async Task Handle_ShouldReturnListOfPokemonsWithNewPokemon_WhenPokemonAdded()
        {
            // Arrange
            var pokemonName = "Pikachu";
            var addPokemonDto = new AddPokemonDto { Name = pokemonName, PokemonTypes = { "Fire" } };
            var pokemonType = new WhosThatPokemon.Models.Type { PokeType = TypeEnum.Fire };
            var pokemonToAdd = new Pokemon { Name = pokemonName, PokemonTypes = { pokemonType } };
            var expectedResponse = new ServiceResponse<List<GetPokemonDto>>
            {
                Data = new List<GetPokemonDto> { new GetPokemonDto { Name = addPokemonDto.Name, PokemonTypes = addPokemonDto.PokemonTypes } },
                Success = true,
                StatusCode = HttpStatusCode.OK
            };
            var query = new AddPokemonCommand(addPokemonDto);

            _mapperMock.Setup(
                x => x.Map<Pokemon>(addPokemonDto))
                .Returns(new Pokemon { Name = addPokemonDto.Name, PokemonTypes = { pokemonType } });

            _pokemonRepositoryMock.Setup(
                x => x.Add(pokemonToAdd));

            _pokemonRepositoryMock.Setup(
                x => x.GetAll())
                .ReturnsAsync(new List<Pokemon> { pokemonToAdd });

            _mapperMock.Setup(
                x => x.Map<GetPokemonDto>(pokemonToAdd))
                .Returns(new GetPokemonDto { Name = addPokemonDto.Name, PokemonTypes = addPokemonDto.PokemonTypes });

            var handler = new AddPokemonCommandHandler(
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
            result.Data.First().Name.Should().Be(expectedResponse.Data.First().Name);
            result.Data.First().PokemonTypes.Should().BeEquivalentTo(expectedResponse.Data.First().PokemonTypes);
        }

        [Fact]
        public async Task Handle_ShouldThrowException_WhenPokemonDataNotValid()
        {
            // Arrange
            var pokemonName = "Pikachu";
            var addPokemonDto = new AddPokemonDto { Name = pokemonName, PokemonTypes = { "NotExistingPokeType" } };
            var query = new AddPokemonCommand(addPokemonDto);

            _validatorMock.Setup(
                x => x.Validate(It.IsAny<AddPokemonCommand>()))
                .Throws(new ValidationExceptionWithStatusCode(new List<ValidationFailure>(), HttpStatusCode.BadRequest));

            var handler = new AddPokemonCommandHandler(
                _pokemonRepositoryMock.Object,
                _mapperMock.Object);

            // Act

            // Assert
            var ex = Assert.Throws<ValidationExceptionWithStatusCode>(() => _validatorMock.Object.Validate(query));
            ex.HttpStatusCode.Should().Be(HttpStatusCode.BadRequest);
        }
    }
}
