using Profile.Domain.CharacterAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Tests.CharacterAgreggate.Models
{
    public class ItemTest
    {
        [Fact]
        public void Should_Create_New_Object_Porperly()
        {
            var name = "Sword";
            var item = new Item(name);

            Assert.NotNull(item);
            Assert.NotEqual(Guid.Empty, item.Id);
            Assert.Equal(name, item.Name);
        }
    }
}
