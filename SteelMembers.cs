using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlDemo
{
    class SteelMember
    {
        public int Id { get; set; }
        public string Profile { get; set; }
        public string Primer { get; set; }
        public double Length { get; set; }


        public static SteelMember[] GetSteelMembers()
        {
            SteelMember[] steelmembers = new SteelMember[4];

            steelmembers[0] = new SteelMember { Id = 101, Profile = "W12X10", Primer = "Red", Length = 120.68 };
            steelmembers[1] = new SteelMember { Id = 102, Profile = "L5X5X3/8", Primer = "Grey", Length = 206.75 };
            steelmembers[2] = new SteelMember { Id = 103, Profile = "C10X15.3", Primer = "Red", Length = 72.88};
            steelmembers[3] = new SteelMember { Id = 104, Profile = "W12X18", Primer = "Black", Length = 468.38 };

            return steelmembers;
        }
    }
}
