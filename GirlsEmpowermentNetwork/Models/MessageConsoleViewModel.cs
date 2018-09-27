using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GirlsEmpowermentNetwork.Models
{
    public class MessageConsoleViewModel
    {
        public string EventId { get; set; }
        public string EventName { get; set; }
        public IEnumerable<string> TemplateNames { get; set; }
        [Required]
        public string MessageBody { get; set; }
    }
}
