using System.Collections.Generic;

namespace GirlsEmpowermentNetwork.Models
{
    public class MessageConsoleViewModel
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public IEnumerable<string> TemplateNames { get; set; }
        public string MessageBody { get; set; }
    }
}
