using Concerts.Interfaces;

namespace Concerts.Classes
{
    internal class Staff : Human, IVip
    {
        public Staff(string name) : base(name)
        {
        }
    }
}
