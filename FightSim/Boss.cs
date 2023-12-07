using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    internal class Boss : GameCharacter
    {
        private Random rand;
        public Boss() : base(400, 10)
        {
            rand = new Random();
        }

        public override void Fight(GameCharacter opponent)
        {
            if (Stamina > 0)
            {
                Strength = rand.Next(0, 31);
                opponent.LooseHealth(Strength);
                Stamina -= 10;
                Console.WriteLine($"Enemy attacks you for {Strength}, you have {opponent.Health} left");
            }
            else
            {
                Recharge("enemy");
            }
        }
    }
}
