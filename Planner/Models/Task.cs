using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planner.Models
{
    public class Task
    {
        public string Subject { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}