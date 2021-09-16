using Lab2.Zyrian.IntercomProject.IntercomUsers;
using Lab2.Zyrian.IntercomProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Zyrian.IntercomProject.SceneSpecifications
{
    public class ObjectAdder
    {
        public House AddHouse() => new House();
        public Guest AddGuest() => new Guest();
        public HouseOwner AddHouseOwner() => new HouseOwner();
        public Bandito AddBandito() => new Bandito();
    }
}
