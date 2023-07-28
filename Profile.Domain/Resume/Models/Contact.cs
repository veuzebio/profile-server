using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Resume.Models
{
    public class Contact: Entity
    {
        public string Name { get; private set; }
        public string Value { get; private set; }

        private Contact()
        {

        }

        public Contact(string name, string value)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        }
    }
}
