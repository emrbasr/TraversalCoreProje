using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Cliend { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
