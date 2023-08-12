using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Planner.Models
{
    public class Day
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}