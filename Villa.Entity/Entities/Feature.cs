using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Feature : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Square { get; set; }
        public string Contract { get; set; }
        public string Payment { get; set; }
        public string Safety { get; set; }
    }
}
