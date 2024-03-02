using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineMassacre.Classes.Helpers
{
    public class Shooter
    {
        //Declaring Shooter variables

        public int bs = 60;
        public int damage = 9;
        public int penetration = 9;
        public int overheatDamageBonus = 2;
        public int overheatPenetrationBonus = 2;
        public int rateOfFire = 5;
        public int overheatStatus = 1;
        public int series = 0;

        public Shooter()
        {
            Console.WriteLine("Type \"Yes\" if you want to customise your Shooter");

            if (Console.ReadLine() == "Yes")
            {
                bool custom_parameters = true;
                //Do stuff here
            }


        }

        public int OverheatStatus()
        {
            if (series % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int HitAmountCalculation(int rollBallisticSkill)
        {
            int hitOverdo = bs - rollBallisticSkill;
            int hitSuccess = 0;

            while (hitOverdo >= 0 && hitSuccess <= rateOfFire)
            {
                hitOverdo = hitOverdo - 10;
                hitSuccess++;
            }
            return hitSuccess;
        }
    }
}