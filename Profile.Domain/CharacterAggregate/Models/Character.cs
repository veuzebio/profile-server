
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
            if (string.IsNullOrEmpty(name)) throw new Exception("Name");

            Id = Guid.NewGuid();
            Name = name;
            Items = items;
        }
    }
}
