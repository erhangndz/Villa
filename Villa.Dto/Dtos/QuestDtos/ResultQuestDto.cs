using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Dto.Dtos.QuestDtos
{
    public class ResultQuestDto
    {
        public ObjectId Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
