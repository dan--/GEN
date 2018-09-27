using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using GirlsEmpowermentNetwork.Models;

namespace GirlsEmpowermentNetwork.Services
{
    public interface IMessageSenderService
    {
        void Send(string templateName, IEnumerable<Volunteer> recipients);
    }

    public class MessageSenderService: IMessageSenderService
    {
        private readonly ITemplateService _templateService;
        private readonly IVolunteerService _volunteerService;

        public MessageSenderService(ITemplateService templateService, IVolunteerService volunteerService)
        {
            _templateService = templateService;
            _volunteerService = volunteerService;
        }

        public void Send(string templateName, IEnumerable<Volunteer> recipients)
        {
            var template = _templateService.GetTemplateByName(templateName);

            foreach (var recipient in recipients)
            {
                var messageBody = CompileTemplate(template, recipient);
                SendMessage(recipient, messageBody);
            }
        }

        private void SendMessage(Volunteer recipient, string messageBody)
        {
            throw new NotImplementedException();
        }

        private string CompileTemplate(Template template, Volunteer recipient)
        {
            var result = template.Body.Replace("@firstname@", recipient.FirstName);

            return result;
        }
    }
}
