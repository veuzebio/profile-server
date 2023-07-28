using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Resume.Models
{
    public class Resume: Entity
    {
        public string Language { get; private set; }
        public Profile Profile { get; private set; }
        public List<Experience> Experiences { get; private set; }
        public List<Education> Educations { get; private set; }
        public List<Contact> Contacts { get; private set; }
        public string[] Skills { get; private set; }

        private Resume()
        {

        }

        public Resume(string language, Profile profile, List<Experience> experiences, List<Education> educations, List<Contact> contacts, string[] skills)
        {
            Id = Guid.NewGuid();
            Language = language;
            Profile = profile;
            Experiences = experiences;
            Educations = educations;
            Contacts = contacts;
            Skills = skills;
        }
    }
}
