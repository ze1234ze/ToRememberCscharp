using Concerts.Classes;

namespace Concerts.Singletons
{
    internal class StaffCatalogue
    {
        private static StaffCatalogue _instance = null;
        public static StaffCatalogue Instance { get {
                if (_instance == null) _instance = new StaffCatalogue();
                return _instance; 
            } 
        }

        List<Staff> AllStaff { get; set; }

        public StaffCatalogue()
        {
            AllStaff = new List<Staff>()
            {
                new Staff("Arne") {},
                new Staff("Benny") {},
                new Staff("Claudia") {},
                new Staff("Dennis") {},
                new Staff("Emil") {},
                new Staff("Friedrich") {},
                new Staff("Gustav") {},
                new Staff("Heino") {},
                new Staff("Ina") {},
                new Staff("Justus") {},
            };
        }

        public List<Staff> GetStaffForEvent(int count)
        { 
            List<Staff> eventStaff = new List<Staff>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                int j = random.Next(AllStaff.Count);
                eventStaff.Add(AllStaff[j]);
            }
            return eventStaff;
        }
    }
}
