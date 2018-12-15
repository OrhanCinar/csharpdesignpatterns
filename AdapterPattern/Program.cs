﻿using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank rx7Tank = new EnemyTank();

            EnemyRobot fredTheRobot = new EnemyRobot();

            EnemyAttacker robotAdapter = new EnemyRobotAdapter(fredTheRobot);

            Console.WriteLine("The Robot");

            fredTheRobot.ReactToHuman("Paul");
            fredTheRobot.WalkForward();
            fredTheRobot.SmashWithHand();

            Console.WriteLine("The Enemy Tank");

            rx7Tank.AssignDriver("Frank");
            rx7Tank.DriveForward();
            rx7Tank.FireWeapon();

            Console.WriteLine("The Robot with Adapter");

            robotAdapter.AssignDriver("Mark");
            robotAdapter.DriveForward();
            robotAdapter.FireWeapon();

            Console.ReadKey();
        }
    }
}
