using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GirlsEmpowermentNetwork.Models;

namespace GirlsEmpowermentNetwork.Repositories
{
    public interface ITemplateRepository
    {
        IEnumerable<Template> Templates();
    }

    public class TemplateRepository : ITemplateRepository
    {
        public IEnumerable<Template> Templates()
        {
            return new List<Template>
            {
                new Template
                {
                    Name = "sample 1",
                    Body = @"
Hey @fistname@, are you going to attend tomorrow's event?
"
                },
                new Template
                {
                    Name = "sample 2",
                    Body = "message body 2"
                }
            };
        }
    }
}
