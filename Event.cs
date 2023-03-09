using Concerts.Classes;
using Concerts.Interfaces;
using Concerts.Singletons;

namespace Concerts.Factories
{
    internal class Event
    {
        public DateTime Date { get; set; }
        public List<Staff> Staff { get; set; }
        public Band Band { get; set; }
        public List<IAccess> Guests { get; set; }
        public static Event CreateEvent(int staffCount, DateTime date, int bandId)
        {
            Event e = new Event();
            e.Date = date;
            e.Staff = StaffCatalogue.Instance.GetStaffForEvent(staffCount);
            e.Band = BandCatalogue.Instance.AllBands[bandId];
            e.Guests = new List<IAccess>();
            return e;
        }
        public bool EnterEvent(IAccess guest)
        {
            Guests!.Add(guest);
            return true;
        }
        public bool StampTicket(ITicket guest)
        {
            guest.StampTicket();
            return true;
        }
        public bool GoBackstage(IVip vip)
        {
            return true;
        }
        public decimal BuyBeer(IAccess guest)
        {
            if ((guest as IVip) != null) return 0;
            return new decimal(4.5);
        }
    }
}
