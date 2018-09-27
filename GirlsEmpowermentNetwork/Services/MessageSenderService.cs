using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using GirlsEmpowermentNetwork.Models;
using GirlsEmpowermentNetwork.Repositories;

namespace GirlsEmpowermentNetwork.Services
{
    public interface IMessageSenderService
    {
        void Send(string templateName, IEnumerable<Volunteer> recipients);
        void SendNewMessage(string messageBody, IEnumerable<Volunteer> recipients);
    }

    public class MessageSenderService: IMessageSenderService
    {
        private readonly ITemplateService _templateService;
        private readonly IVolunteerService _volunteerService;
        private readonly TwilioRepository _twilioRepository;

        public MessageSenderService(ITemplateService templateService, IVolunteerService volunteerService, 
            TwilioRepository twilioRepository)
        {
            _templateService = templateService;
            _volunteerService = volunteerService;
            _twilioRepository = twilioRepository;
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

        public void SendNewMessage(string messageBody, IEnumerable<Volunteer> recipients)
        {
            var temporaryTemplate = new Template();
            temporaryTemplate.Body = messageBody;
            foreach (var recipient in recipients)
            {
                messageBody = CompileTemplate(temporaryTemplate, recipient);
                SendMessage(recipient, messageBody);
            }
        }

        private void SendMessage(Volunteer recipient, string messageBody)
        {
            _twilioRepository.Send(messageBody, recipient.MobileNumber);
        }

        private string CompileTemplate(Template template, Volunteer recipient)
        {
            var result = template.Body;
            if (template.Body.Contains("@firstname@"))
            {
                result = template.Body.Replace("@firstname@", recipient.FirstName);
            }

            return result;
        }
    }
}
