using System;

namespace workspace1
{
    class Player
    {
        public bool isAlive
        {
          get { return health > 0;}  
        }
        
        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5,50);
        }

        public int Health
        {
            get { return health; }
        }
        

    }
    class Program
    {

        static void Main(string[] args)
        {

            Player player1 = new Player();

            Player player2 = new Player();

            void Attack()
            {
                Random attack = new Random();
                
                if (attack.Next(1,3) == 1)
                {
                    player2.Hit();
                    Console.WriteLine($"Player 2 was attacked and now has the health of {player2.Health}.");
                    if (player2.Health <= 0)
                    {
                        Console.WriteLine("Player 2 died.\nPlayer 1 is the winner.");
                    }
                } else {
                    player1.Hit();
                    Console.WriteLine($"Player 1 was attacked and now has the health of {player1.Health}.");
                    if (player1.Health <= 0)
                    {
                        Console.WriteLine("Player 1 died.\nPlayer 2 is the winner.");
                    }
                }
            }

            Console.WriteLine("Let's get ready to rumble!\nPlayer 1 and 2 will fight for their lives in the gladiators' arena.");
            while (player1.Health > 0 && player2.Health > 0)
            {
                Attack();
            }

        }
    }
}
