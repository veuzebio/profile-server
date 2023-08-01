using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profile.Application.Resume.Commands
{
    public class CreateNewCharacterCommand: IRequest<Guid>
    {
        public string Name { get; set; }
        
        public string[] Items { get; set; }
    }
}
