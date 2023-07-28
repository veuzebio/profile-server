using Profile.Domain.Resume.Interfaces;
using DomainModel = Profile.Domain.Resume.Models;

namespace Profile.Infra.Data.Repository.Resume
{
    public class ResumeRepository : IResumeRepository
    {
        public void Create(DomainModel.Resume resume)
        {
            Console.WriteLine("Created!");
        }

        public DomainModel.Resume GetByLanguage(string language)
        {
            throw new NotImplementedException();
        }
    }
}
