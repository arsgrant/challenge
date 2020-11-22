using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_api.Model
{
    public class Schedule
    {
        public DateTime Date { get; set; }
        public List<ScheduleTime> times { get; set; }

        public static implicit operator Schedule(List<Schedule> v)
        {
            throw new NotImplementedException();
        }
    }
}
