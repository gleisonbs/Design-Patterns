using System;

namespace APLib
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot _enemyRobot;
        public EnemyRobotAdapter(EnemyRobot enemyRobot) 
        { 
            _enemyRobot = enemyRobot; 
        }

        public void FireWeapon() 
        { 
            _enemyRobot.SmashWithHands();
        }

        public void DriveForward() 
        { 
            _enemyRobot.WalkForward();
        }

        public void AssignDriver(string driverName) 
        { 
            _enemyRobot.ReactToHuman(driverName);
        }
    }
}
