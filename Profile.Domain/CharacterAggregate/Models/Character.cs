
namespace Profile.Domain.CharacterAggregate.Models
{
    public class Character : Entity
    {
        public string Name { get; private set; }
        public List<Item> Items { get; private set; }

        private Character() { }

        public Character(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }
    }
}
