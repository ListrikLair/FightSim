using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero();
            var boss = new Boss();
            var enemy = new Enemy();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("You are a fresh hero looking to train to become the greatest hero the world has ever seen" +
                                  "\nWelcome to the training hall!" +
                                  "\nDo you want to fight a (normal) enemy, or a (challenging) one?");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "normal":
                        InitFight("normal");
                        break;
                    case "challenging":
                        InitFight("boss");
                        break;
                    default:
                        continue;
                }
            }

            void InitFight(string type)
            {
                GameCharacter opponent;
                if (type == "normal")
                {
                    opponent = enemy;
                }
                else
                {
                    opponent = boss;
                }
                Game(opponent);
            }

            void Game(GameCharacter opponent)
            {
                var player = hero;
                while (player.Health > 0 && opponent.Health > 0)
                {
                    player.Fight(opponent);
                    opponent.Fight(player);
                }

                if (player.Health > 0 && opponent.Health > 0)
                {
                    Console.WriteLine("It's a draw!");
                } else if (player.Health > 0)
                {
                    Console.WriteLine("You Win!");
                }
                else
                {
                    Console.WriteLine("You lost...");
                }

                hero.Reset();
                boss.Reset();
                enemy.Reset();
                Console.ReadKey();
            }
        }
    }
}