using GirlsEmpowermentNetwork.Models;

namespace GirlsEmpowermentNetwork.Services
{
    public interface ITemplateService
    {
        Template GetTemplateByName(string name);
    }

    public class TemplateService : ITemplateService
    {
        public Template GetTemplateByName(string name)
        {
            return new Template
            {
                Name = "sample 1",
                Body = @"
Hey @fistname@, are you going to attend tomorrow's event?
"
            };
        }
    }
}
