using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.WorldOfTanks
{
    public class Tank
    {
        private string name;
        private int complect;
        private int armor;
        private int movement;
        public int Complect
        {
            get
            {
                return complect;
            }
        }
        public int Armor
        {
            get
            {
                return armor;
            }
        }
        public int Movement
        {
            get
            {
                return movement;
            }
        }
        public Tank(string name)
        {
            Random r = new Random();
            this.name = name;
            complect = r.Next(0, 100);
            armor = r.Next(0, 100);
            movement = r.Next(0,100);
        }
        public Tank()
        {
            Random r = new Random();
            name = "Tank";
            complect = r.Next(0, 100);
            armor = r.Next(0, 100);
            movement = r.Next(0, 100);
        }
        public static bool operator ^(Tank t1, Tank t2)
        {
            int scoret1=0;
            int scoret2=0;
            if (t1.Movement > t2.Movement)
            {
                scoret1++;
            }
            else if (t2.Movement > t1.Movement)
            {
                scoret2++;
            }
            if (t1.Complect > t2.Complect)
            {
                scoret1++;
            }
            else if (t2.Complect > t1.Complect)
            {
                scoret2++;
            }
            if (t1.Armor > t2.Armor)
            {
                scoret1++;
            }
            else if (t2.Armor > t1.Armor)
            {
                scoret2++;
            }
           // scoret1=t1.Armor > t2.Armor ? scoret1++ : scoret1;
           // scoret2 = t2.Armor > t1.Armor ? scoret2++ : scoret2;
           // scoret1 = t1.Complect > t2.Complect ? scoret1++ : scoret1;
           // scoret2 = t2.Complect > t1.Complect ? scoret2++ : scoret2;
           //if (scoret2 == scoret1)
           //{
           //    throw new Exception("equals");
           //}
            if (scoret1 > scoret2) return true;
            else return false;
        }
        public override string ToString()
        {
            return String.Format("Armor = " + Armor + "  Complect = " + Complect + "  Movement = " + Movement);
        }
    }
}
