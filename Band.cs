using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concerts.Classes
{
    internal class Band
    {
        public string Name { get; set; }
        public List<BandMember> Members { get; set; }
        public Band(string name) 
        { 
            Name = name;
            Members = new List<BandMember>();
        }
    }
}
