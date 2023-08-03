using Profile.Domain.CharacterAggregate.Models;

namespace Profile.Domain.Tests.CharacterAgreggate.Models
{
    public class CharacterTest
    {
        [Fact]
        public void Should_Create_New_Object_Porperly()
        {
            var name = "John Doe";
            var items = new List<Item>()
            {
                new Item("Sword")
            };

            var character = new Character(name, items);

            Assert.NotNull(character);
            Assert.NotEqual(Guid.Empty, character.Id);
            Assert.Equal(name, character.Name);
            Assert.Equal(items, character.Items);
            Assert.Equal(items[0].Name, character.Items[0].Name);
        }
    }
}
