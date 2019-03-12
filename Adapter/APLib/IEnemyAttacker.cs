﻿using System;

namespace APLib
{
    public interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string driverName);
    }
}
