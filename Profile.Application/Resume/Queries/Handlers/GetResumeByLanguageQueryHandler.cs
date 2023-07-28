using MediatR;
using Profile.Domain.Resume.Interfaces;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Application.Resume.Queries.Handlers
{
    public class GetResumeByLanguageQueryHandler : IRequestHandler<GetResumeByLanguageQuery, DomainModel.Resume>
    {
        private readonly IResumeRepository _resumeRepository;

        public GetResumeByLanguageQueryHandler(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public Task<DomainModel.Resume> Handle(GetResumeByLanguageQuery request, CancellationToken cancellationToken)
        {
            var resume = _resumeRepository.GetByLanguage(request.Language);

            return Task.FromResult(resume);
        }
    }
}
