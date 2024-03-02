using System;
using MarineMassacre.Classes.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace MarineMassacre.Classes.Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Imma murder your Targets");
            Target Target = new Target();
            Shooter Shooter = new Shooter();
            int series = 0;
            while (Target.Crits.Max() < 9)
            {
                series++;
                int rollBallisticSkill = Die.Roll(100);
                int hitLocation = Target.DetermineHitLocation(rollBallisticSkill);
                int hitAmount = Shooter.HitAmountCalculation(rollBallisticSkill);
                while (hitAmount > 0)
                {
                    if (Die.Roll(100) > Target.forcefield)
                    {
                        DamageCalculation.HitResults(Die.Roll(10), Die.Roll(10), Die.Roll(10), Shooter, Target, hitLocation);
                        hitLocation = (hitLocation + 1) % 6;
                    }
                    hitAmount--;
                }
            }
        }
    }
}