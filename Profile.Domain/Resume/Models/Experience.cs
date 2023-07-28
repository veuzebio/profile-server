using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Resume.Models
{
    public class Experience : Entity
    {
        public string Company { get; private set; }
        public string Role { get; private set; }
        public string Description { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        private Experience()
        {

        }

        public Experience(string company, string role, string description, DateTime start, DateTime end)
        {
            Id = Guid.NewGuid();
            Company = company;
            Role = role;
            Description = description;
            Start = start;
            End = end;
        }
    }
}
