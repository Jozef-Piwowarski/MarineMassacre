namespace MarineMassacre.Classes.Helpers
{
    public class Target
    {
        //Declaring Target variables

        public int wounds = 23;
        public int toughnessBonus = 6;
        public int toughnessBonusModifier = 2;
        public int[] Crits = { 0, 0, 0, 0, 0, 0 };
        public int[] Armor = { 15, 15, 15, 15, 15, 15 };
        public int[] Locations = { 10, 20, 30, 70, 85, 100 };
        public int forcefield = 35;
        public int truegrit = 1;
        public bool forcefieldStatus = true;

        public Target()
        {
            Console.WriteLine("Type \"Yes\" if you want to customise your Target");

            if (Console.ReadLine() == "Yes")
            {
                bool custom_parameters = true;
                //Do stuff here
            }
        }


        public Target(int wounds, int toughnessBonus, int toughnessBonusModifier, int headArmor, int rightArmArmor, int leftArmArmor, int bodyArmor, int rightLegArmor, int leftLegArmor, int forceField, bool forcefieldStatus, int trueGrit)
        {
            this.wounds = wounds;
            this.toughnessBonus = toughnessBonus;
            this.toughnessBonusModifier = toughnessBonusModifier;
            int[] Armor = { headArmor, rightArmArmor, leftArmArmor, bodyArmor, rightLegArmor, leftLegArmor };
            forcefield = forceField;
            this.forcefieldStatus = forcefieldStatus;
            truegrit = trueGrit;
        }


        public int DetermineHitLocation(int roll_bs)
        {
            for (int i = 0; i < Locations.Length; i++)
            {
                if (Die.Flip(roll_bs) < Locations[i])
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
