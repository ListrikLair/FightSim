using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    internal abstract class GameCharacter
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int MaxStamina { get; set; }


        public GameCharacter(int health, int stamina)
        {
            Health = MaxHealth = health;
            Stamina = MaxStamina = stamina;
        }

        public abstract void Fight(GameCharacter opponent);

        public void LooseHealth(int strength)
        {
            Health -= strength;
        }

        public void Recharge(string character)
        {
            Stamina = MaxStamina;
            if (character == "player")
            {
                Console.WriteLine("You had to rest and recharge your energy...");
            }
            else
            {
                Console.WriteLine("Your enemy had to rest and recharge their energy!");
            }
        }

        public void Reset()
        {
            Health = MaxHealth;
            Stamina = MaxStamina;
        }
    }
}
