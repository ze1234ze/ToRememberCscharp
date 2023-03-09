using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concerts.Interfaces
{
    internal interface ITicket : IAccess
    {
        bool stamped { get; set; }
        void StampTicket();
    }
}
