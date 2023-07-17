using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Command
    {
        public int CommandId { get; set; }
        public string CommandUser { get; set; }
        public DateTime CommandDate { get; set; }
        public string CommandContent { get; set; }
        public bool CommandState { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
