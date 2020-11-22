using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_api.Model
{
    public class Professional
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Branch { get; set; }
        public String Location { get; set; }
        public Decimal Value { get; set; }
        public int Time { get; set; }
        public String About { get; set; }
    }
}
