using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHWebAPI.Models
{
    public class AEvent
    {
        public string EventName { get; set; }
        public string EventURL { get; set; }
        public string EventLocation { get; set; }
        public string EventSummary { get; set; }
    }
}