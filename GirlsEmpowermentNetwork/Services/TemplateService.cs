using System;
using System.Collections.Generic;
using System.Linq;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Repositories;

namespace GirlsEmpowermentNetwork.Services
{
    public interface ITemplateService
    {
        Template GetTemplateByName(string name);
        IEnumerable<string> GetAllTemplateNames();
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

        public IEnumerable<string> GetAllTemplateNames()
        {
            return _templateRepository.Templates().Select(t => t.Name);
        }
    }
}
