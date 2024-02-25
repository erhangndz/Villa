using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.CounterDtos
{
    public class UpdateCounterDto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
    }
}
