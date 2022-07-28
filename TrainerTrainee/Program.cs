using TrainerTrainee;

Organization org = new Organization();
Console.Write("Enter Organisation Name:");
org.Name = Console.ReadLine();

Trainer trainer = new Trainer();
trainer.org = org;

Trainee t1 = new Trainee();
Trainee t2 = new Trainee();
Trainee t3 = new Trainee();
Trainee t4 = new Trainee();
Trainee t5 = new Trainee();

t1.Trainer = trainer;
t2.Trainer = trainer;
t3.Trainer = trainer;
t4.Trainer = trainer;
t5.Trainer = trainer;

Training training = new Training();
training.trainer = trainer;
training.trainees.Add(t1);
training.trainees.Add(t2);
training.trainees.Add(t3);
training.trainees.Add(t4);
training.trainees.Add(t5);

t1.trainings.Add(training);
t2.trainings.Add(training);
t3.trainings.Add(training);
t4.trainings.Add(training);
t5.trainings.Add(training);

Course course = new Course();
training.course = course;
course.T.Add(training);

Module m1 = new Module();
Module m2 = new Module();
Module m3 = new Module();

course.Modules.Add(m1);
course.Modules.Add(m2);
course.Modules.Add(m3);

Unit u1 = new Unit();
u1.Duration = 50;
m1.units.Add(u1);
Unit u2 = new Unit();
u2.Duration = 100;
m1.units.Add(u2);
Unit u3 = new Unit();
u3.Duration = 120;
m2.units.Add(u3);
Unit u4 = new Unit();
u4.Duration = 10;
m2.units.Add(u4);
Unit u5 = new Unit();
u5.Duration = 56;
m3.units.Add(u5);

Topic to1 = new Topic();
to1.Topic_name = "C++";
u1.Topics.Add(to1);

Console.WriteLine($"Organization Name:{training.Organization_name()}");
Console.WriteLine($"Number of Trainees:{training.No_of_trainees()}");
Console.WriteLine($"Total Duration:{training.Training_duration()}");
