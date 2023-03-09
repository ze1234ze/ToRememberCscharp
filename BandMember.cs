using Concerts.Interfaces;

namespace Concerts.Classes
{
    internal class BandMember : Human, IVip
    {
        public BandMember(string name, List<RoleModel> roles) : base(name)
        {
            Roles = roles;
        }
        public List<RoleModel> Roles { get; set; } 
        public enum RoleModel
        {
            Singer,
            Guitarist,
            Bassist,
            Drummer,
            Roadie
        }
    }
}
