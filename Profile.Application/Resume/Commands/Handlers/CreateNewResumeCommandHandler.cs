using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Application.Resume.Commands.Handlers
{
    public class CreateNewResumeCommandHandler : IRequestHandler<CreateNewResumeCommand, bool>
    {
        public Task<bool> Handle(CreateNewResumeCommand request, CancellationToken cancellationToken)
        {
            var profile = new DomainModel.Profile(request.Name, request.Age, request.Description);

            var experiences = new List<DomainModel.Experience>();

            foreach (var experience in request.Experiences)
            {
                experiences.Add(new DomainModel.Experience(experience.Company, experience.Role, experience.Description, experience.Start, experience.End));
            }

            var educations = new List<DomainModel.Education>();

            foreach (var education in request.Educations)
            {
                educations.Add(new DomainModel.Education(education.Institution, education.Degree, education.Start, education.End));
            }

            var contacts = new List<DomainModel.Contact>();

            foreach (var contact in request.Contacts)
            {
                contacts.Add(new DomainModel.Contact(contact.Name, contact.Value));
            }

            var resume = new DomainModel.Resume(request.DocumentLanguage, profile, experiences, educations, contacts, request.Skills);

            return Task.FromResult(true);
        }
    }
}
