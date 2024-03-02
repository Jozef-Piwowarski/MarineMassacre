using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarineMassacre.Classes.Helpers
{
    public static class DamageCalculation
    {
        public static int Damage(int roll_dmg1, int roll_dmg2, int roll_dmg3, Shooter Shooter, Target Target, int hitLocation)
        {
            int damageAfterReduction = Math.Max(roll_dmg1 + roll_dmg2 + roll_dmg3 * Shooter.overheatStatus + Shooter.damage + Shooter.overheatDamageBonus * Shooter.overheatStatus - Target.toughnessBonus * Target.toughnessBonusModifier - Math.Max(Target.Armor[hitLocation] - Shooter.penetration - Shooter.overheatPenetrationBonus * Shooter.OverheatStatus(), 0), 0);

            return damageAfterReduction;
        }



        public static void HitResults(int roll_dmg1, int roll_dmg2, int roll_dmg3, Shooter Shooter, Target Target, int hitLocation)
        {
            int damageAfterReduction = Damage(roll_dmg1, roll_dmg2, roll_dmg3, Shooter, Target, hitLocation);
            DealWounds(Target, damageAfterReduction);
            DealCrits(Target, hitLocation);
            DealArmorDamage(Target, hitLocation, damageAfterReduction);
        }

        public static void DealWounds(Target Target, int damageAfterReduction)
        {
            Target.wounds = Target.wounds - damageAfterReduction;
        }

        public static void DealCrits(Target Target, int hitLocation)
        {
            if (Target.wounds < -Target.toughnessBonus * Target.truegrit)
            {
                Target.Crits[hitLocation] = Target.Crits[hitLocation] - Target.wounds + Target.toughnessBonus;
            }
            Target.wounds = Math.Max(Target.wounds, 0);
        }

        public static void DealArmorDamage(Target Target, int hitLocation, int damageAfterReduction)
        {
            if (damageAfterReduction > Target.Armor[hitLocation] + Target.toughnessBonus * Target.toughnessBonusModifier && Target.Armor[hitLocation] > 0)
            {
                Target.Armor[hitLocation] = Target.Armor[hitLocation]--;
            }
        }

    }
}
