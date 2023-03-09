using Concerts.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concerts.Singletons
{
    internal class BandCatalogue
    {
        private static BandCatalogue _instance = null;
        public static BandCatalogue Instance
        {
            get
            {
                if (_instance == null) _instance = new BandCatalogue();
                return _instance;
            }
        }

        public List<Band> AllBands { get; set; }

        public BandCatalogue()
        {
            AllBands = new List<Band>()
            {
                new Band("Power Trio") { 
                    Members = new List<BandMember>() { 
                        new BandMember("Arno", new List<BandMember.RoleModel>() { BandMember.RoleModel.Singer, BandMember.RoleModel.Guitarist }),
                        new BandMember("Gerry", new List<BandMember.RoleModel>() { BandMember.RoleModel.Bassist }),
                        new BandMember("Walter", new List<BandMember.RoleModel>() { BandMember.RoleModel.Drummer })
                    }
                },
                new Band("Die 4 von der Tankstelle") {
                    Members = new List<BandMember>() {
                        new BandMember("Harry", new List<BandMember.RoleModel>() { BandMember.RoleModel.Singer }),
                        new BandMember("Klaus", new List<BandMember.RoleModel>() { BandMember.RoleModel.Guitarist }),
                        new BandMember("Roger", new List<BandMember.RoleModel>() { BandMember.RoleModel.Bassist }),
                        new BandMember("Harald", new List<BandMember.RoleModel>() { BandMember.RoleModel.Drummer })
                    }
                },
                new Band("Band Band") {
                    Members = new List<BandMember>() {
                        new BandMember("Rudi", new List<BandMember.RoleModel>() { BandMember.RoleModel.Singer }),
                        new BandMember("Willy", new List<BandMember.RoleModel>() { BandMember.RoleModel.Guitarist }),
                        new BandMember("Martin", new List<BandMember.RoleModel>() { BandMember.RoleModel.Guitarist }),
                        new BandMember("Jens", new List<BandMember.RoleModel>() { BandMember.RoleModel.Bassist }),
                        new BandMember("Berndt", new List<BandMember.RoleModel>() { BandMember.RoleModel.Drummer })
                    }
                },
            };
        }
    }
}
