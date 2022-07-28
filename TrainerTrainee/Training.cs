using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    internal class Training
    {
        public Trainer trainer { get; set; }
        public List<Trainee> trainees { get; set; } = new List<Trainee>();
        public Course course { get; set; }

        public int No_of_trainees()
        {
            return trainees.Count;
        }

        public string Organization_name()
        {
            return trainer.org.Name;
        }

        public int Training_duration()
        {
            int duration = 0;
            foreach(Module module in course.Modules )
            {
                foreach (Unit unit in module.units)
                {
                    duration += unit.Duration;
                }
            }
            return duration;
        }


    }
}
