using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class SubHeader:BaseEntity
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Instagram { get; set; }
    }
}
