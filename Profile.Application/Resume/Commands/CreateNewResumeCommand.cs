using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Application.Resume.Commands
{
    public class CreateNewResumeCommand: IRequest<bool>
    {
        public string DocumentLanguage { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Contact> Contacts { get; set; }
        public string[] Skills { get; set; }

        public class Experience
        {
            public string Company { get; set; }
            public string Role { get; set; }
            public string Description { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }

        public class Education
        {
            public string Institution { get; set; }
            public string Degree { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
        }

        public class Contact
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}
