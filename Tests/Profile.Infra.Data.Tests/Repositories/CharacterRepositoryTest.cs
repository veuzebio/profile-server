using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using Profile.Domain.CharacterAggregate.Interfaces;
using Profile.Domain.CharacterAggregate.Models;
using Profile.Infra.Data.Repositories;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace Profile.Infra.Data.Tests.Repositories
{
    public class CharacterRepositoryTest
    {
        private readonly Mock<ProfileDbContext> _contextMock;
        private readonly ICharacterRepository _characterRepository;

        public CharacterRepositoryTest()
        {
            _contextMock = new Mock<ProfileDbContext>();

            var items = new List<Item>()
            {
                new Item("Sword")
            };

            var characters = new List<Character>() {
                new Character("John", items),
                new Character("Mary", items),
            };

            _contextMock
                .Setup(x => x.Characters)
                .ReturnsDbSet(characters);

            _contextMock
                .Setup(x => x.SaveChangesAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(1);

            _characterRepository = new CharacterRepository(_contextMock.Object);
        }

        [Fact]
        public async Task CreateAsync_Should_AddNewRegister_On_Database()
        {
            var name = "John Doe";
            var items = new List<Item>()
            {
                new Item("Sword")
            };

            var character = new Character(name, items);

            await _characterRepository.CreateAsync(character);

            _contextMock.Verify(x => x.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
            _contextMock.Verify(x => x.Characters.Add(character), Times.Once);
        }
    }
}

