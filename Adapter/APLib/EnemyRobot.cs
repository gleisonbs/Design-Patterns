using System;

namespace APLib
{
    public class EnemyRobot
    {
        public void SmashWithHands()
        {
            Random random = new Random();
            int damage = random.Next(1, 10);
            Console.WriteLine($"Robot does {damage} damage");
        }

        public void WalkForward()
        {
            Random random = new Random();
            int movement = random.Next(1, 3);
            Console.WriteLine($"Robot moves {movement} meters");
        }

        public void ReactToHuman(string humanName)
        {
            Console.WriteLine($"Robot kills {humanName}");
        }
    }
}
