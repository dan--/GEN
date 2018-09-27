using System;
using System.Linq;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Repositories;

namespace GirlsEmpowermentNetwork.Services
{
    public interface ITemplateService
    {
        Template GetTemplateByName(string name);
    }

    public class TemplateService : ITemplateService
    {
        private readonly ITemplateRepository _templateRepository;

        public TemplateService(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        public Template GetTemplateByName(string name)
        {
            var template = _templateRepository.Templates().SingleOrDefault(t => string.Equals(t.Name, name, StringComparison.CurrentCultureIgnoreCase));

            return template;
        }
    }
}
