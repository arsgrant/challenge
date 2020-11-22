using challenge_api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_api.Mock
{
    public class MockData
    {
        private List<ScheduleTime> GetTimes()
        {
            List<ScheduleTime> list = new List<ScheduleTime>();

            Random rand = new Random();
            list.Add(new ScheduleTime() { Time = "08:00", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "08:30", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "09:00", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "09:30", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "10:00", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "10:30", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "11:00", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "11:30", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "14:00", Busy = rand.Next(2) == 0 });
            list.Add(new ScheduleTime() { Time = "14:30", Busy = rand.Next(2) == 0 });

            return list;
        }
        private List<Schedule> GetSchedules()
        {
            List<Schedule> list = new List<Schedule>();

            for (int i = 0; i < 10; i++)
            {
                Schedule schedule = new Schedule() { Date = DateTime.Now.AddDays(i) };
                schedule.times = this.GetTimes();
                list.Add(schedule);
            }

            return list;
        }

        public List<Professional> GetListProfessional()
        {
            List<Professional> list = new List<Professional>();

            Professional professional = new Professional();
            professional.Id = 1;
            professional.Name = "Joana Vasconcelos";
            professional.Branch = "PSICOLOGIST";
            professional.Location = "Lisboa";
            professional.Value = 160;
            professional.Time = 50;
            professional.About = "Mussum Ipsum, cacilds vidis litro abertis. Admodum accumsan disputationi eu sit. Vide electram sadipscing et per. Todo mundo vê os porris que eu tomo, mas ninguém vê os tombis que eu levo! Em pé sem cair, deitado sem dormir, sentado sem cochilar e fazendo pose. Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi";
            list.Add(professional);

            professional = new Professional();
            professional = new Professional();
            professional.Id = 2;
            professional.Name = "Amália Rodrigues";
            professional.Branch = "PSICOLOGIST";
            professional.Location = "Lisboa";
            professional.Value = 140;
            professional.Time = 50;
            professional.About = "Mussum Ipsum, cacilds vidis litro abertis. Admodum accumsan disputationi eu sit. Vide electram sadipscing et per. Todo mundo vê os porris que eu tomo, mas ninguém vê os tombis que eu levo! Em pé sem cair, deitado sem dormir, sentado sem cochilar e fazendo pose. Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi";
            list.Add(professional);

            professional = new Professional();
            professional = new Professional();
            professional.Id = 3;
            professional.Name = "Fernando Pessoa";
            professional.Branch = "PSICOLOGIST";
            professional.Location = "Lisboa";
            professional.Value = 180;
            professional.Time = 50;
            professional.About = "Mussum Ipsum, cacilds vidis litro abertis. Admodum accumsan disputationi eu sit. Vide electram sadipscing et per. Todo mundo vê os porris que eu tomo, mas ninguém vê os tombis que eu levo! Em pé sem cair, deitado sem dormir, sentado sem cochilar e fazendo pose. Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi";
            list.Add(professional);

            professional = new Professional();
            professional = new Professional();
            professional.Id = 4;
            professional.Name = "Rui Veloso";
            professional.Branch = "PSICOLOGIST";
            professional.Location = "Lisboa";
            professional.Value = 160;
            professional.Time = 50;
            professional.About = "Mussum Ipsum, cacilds vidis litro abertis. Admodum accumsan disputationi eu sit. Vide electram sadipscing et per. Todo mundo vê os porris que eu tomo, mas ninguém vê os tombis que eu levo! Em pé sem cair, deitado sem dormir, sentado sem cochilar e fazendo pose. Posuere libero varius. Nullam a nisl ut ante blandit hendrerit. Aenean sit amet nisi";
            list.Add(professional);

            return list;
        }

        public List<Schedule> GetListProfessionalSchedule ()
        {
            List<Schedule> list = this.GetSchedules();
            return list;
        }

    }
}
