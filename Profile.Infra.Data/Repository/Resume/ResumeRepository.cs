using Profile.Domain.Resume.Interfaces;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Infra.Data.Repository.Resume
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly ProfileDbContext _context;

        public ResumeRepository(ProfileDbContext context)
        {
            _context = context;
        }

        public void Create(DomainModel.Resume resume)
        {
            _context.Resumes.Add(resume);
        }

        public DomainModel.Resume GetByLanguage(string language)
        {
            return _context.Resumes.Where(x => x.Language == language).FirstOrDefault();
        }
    }
}
