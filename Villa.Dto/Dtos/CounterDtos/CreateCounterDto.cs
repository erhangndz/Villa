using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.CounterDtos
{
    public class CreateCounterDto
    {
       
        public string Title { get; set; }
        public string Count { get; set; }
    }
}
