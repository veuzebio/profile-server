
namespace Profile.Domain.CharacterAggregate.Models
{
    /// <summary>
    /// Power item representation.
    /// </summary>
    public class Item: Entity
    {
        /// <summary>
        /// Item's popular name.
        /// </summary>
        public string Name { get; private set; }

        private Item() { }

        public Item(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
