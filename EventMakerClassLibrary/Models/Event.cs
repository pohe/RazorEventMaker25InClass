using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerClassLibrary.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string City { get; set; }

        public DateTime DateTime { get; set; }

        public Event()
        {
        }

    }


}
