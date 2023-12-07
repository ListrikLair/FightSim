using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    internal class Enemy : GameCharacter
    {
        private Random rand;
        public Enemy() : base(150, 20)
        {
            rand = new Random();
        }

        public override void Fight(GameCharacter opponent)
        {
            if (Stamina > 0)
            {
                Strength = rand.Next(0, 11);
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
