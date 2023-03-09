using Concerts.Interfaces;

namespace Concerts.Classes
{
    internal class Guest : Human, ITicket
    {
        public bool stamped { get; set; }
        public Guest(string name) : base(name) 
        {
            stamped = false;
        }
        public void StampTicket()
        {
            stamped = true;
        }
    }
}
