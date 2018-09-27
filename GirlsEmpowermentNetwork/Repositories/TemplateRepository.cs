using System.Collections.Generic;
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
                    Name = "Event Message",
                    Body = "Hi @firstname@! Can’t wait to see you tomorrow at 8am for We Are Girls Austin. Just come check in with me at Volunteer Registration, and then I can send you to the workshop space to get started."
},
                new Template
                {
                    Name = "Reminder Message",
                    Body = "Hi @firstname@! So excited to see you at the workshop this Saturday! Just a reminder that we’re doing Power Chats, so professional dress is important."
                },
                new Template
                {
                    Name = "Update Message",
                    Body = "Hi @firstname@! Hope you had a good day. Can’t wait to see you tonight at the GEN Town Hall! We’ll have drinks and snacks galore."
                }
            };
        }
    }
}
