using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    internal class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> trainings { get; set; } = new List<Training>();
    }
}
