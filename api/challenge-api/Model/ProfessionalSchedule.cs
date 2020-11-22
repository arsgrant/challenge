using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_api.Model
{
    public class ProfessionalSchedule
    {
        public Professional professional { get; set; }
        public List<Schedule> listSchedule { get; set; }
    }
}
