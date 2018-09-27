using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GirlsEmpowermentNetwork.Models
{
    public class MessageConsoleViewModel
    {
        public IEnumerable<string> TemplateNames { get; set; }
    }
}
