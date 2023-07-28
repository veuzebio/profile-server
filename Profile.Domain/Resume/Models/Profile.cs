using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Resume.Models
{
    public class Profile : Entity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Description { get; private set; }

        private Profile()
        {

        }

        public Profile(string name, int age, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Description = description;
        }
    }
}
