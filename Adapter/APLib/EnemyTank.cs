using System;

namespace APLib
{
    public class EnemyTank : IEnemyAttacker
    {
        public void FireWeapon()
        {
            Random random = new Random();
            int damage = random.Next(1, 20);
            Console.WriteLine($"Tank does {damage} damage");
        }

        public void DriveForward()
        {
            Random random = new Random();
            int movement = random.Next(1, 6);
            Console.WriteLine($"Tank moves {movement} meters");
        }

        public void AssignDriver(string driverName)
        {
            Console.WriteLine($"{driverName} is the assigned driver");
        }
    }
}
