using System;
using APLib;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemyAttacker enemyTank = new EnemyTank();
            enemyTank.FireWeapon();

            EnemyRobot enemyRobot = new EnemyRobot();
            IEnemyAttacker robotAttacker = new EnemyRobotAdapter(enemyRobot);
            robotAttacker.FireWeapon();
        }
    }
}
