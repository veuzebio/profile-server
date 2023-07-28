using MediatR;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Application.Resume.Queries
{
    public class GetResumeByLanguageQuery: IRequest<DomainModel.Resume>
    {
        public string Language { get; set; }
    }
}
