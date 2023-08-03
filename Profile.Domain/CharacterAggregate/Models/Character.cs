
namespace Profile.Domain.CharacterAggregate.Models
{
    /// <summary>
    /// Character's profile.
    /// </summary>
    public class Character : Entity
    {
        /// <summary>
        /// Character's name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Character's inventory of items
        /// </summary>
        public List<Item> Items { get; private set; }

        private Character() { }

        public Character(string name, List<Item> items)
        {
            Name = name;
            Items = items;
        }
    }
}
