using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    internal class Unit
    {
        public List<Topic> Topics { get; set; }= new List<Topic>();
        public int Duration { get; set; }
    }
}
