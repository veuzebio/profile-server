using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Domain.Resume.Interfaces
{
    public interface IResumeRepository
    {
        public void Create(Models.Resume resume);
        public Models.Resume GetByLanguage(string language);
    }
}
