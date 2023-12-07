using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    internal class Hero : GameCharacter

    {
        public Hero() : base(100, 40)
        {
            Strength = 20;
        }

        public override void Fight(GameCharacter opponent)
        {
            if (Stamina > 0)
            {
                opponent.LooseHealth(Strength);
                Stamina -= 10;
                Console.WriteLine($"You attack the enemy for {Strength}, it has {opponent.Health} left");
            }
            else
            {
                Recharge("player");
            }
        }
    }
}
