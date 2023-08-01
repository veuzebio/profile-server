
namespace Profile.Domain.CharacterAggregate.Models
{
    public class Item: Entity
    {
        public string Name { get; private set; }

        private Item() { }

        public Item(string name)
        {
            Name = name;
        }
    }
}
