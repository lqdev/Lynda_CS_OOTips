﻿using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //var comp = new Desktop("Generic Computer",Desktop.CaseType.Tower);
            var comp = new Laptop("Generic Laptop",1024,768);
            Console.WriteLine("Computer Type - " + comp.GetType());

            var isComputer = comp is Computer;

            Console.WriteLine("Is computer - " + isComputer);
            Console.WriteLine("Computer name - " + comp.name);
            //Console.WriteLine("Computer case - " + comp.caseType);

            comp.TogglePower();
            Console.WriteLine("Computer is on - " + comp.isOn);

            var sleepingComp = comp as ISleep;

            if(sleepingComp != null)
            {
                sleepingComp.ToggleSleep();
                Console.WriteLine("Computer is sleeping - " + sleepingComp.isSleeping);

                comp.TogglePower();
                Console.WriteLine("Computer is on - " + comp.isOn);
            }


            Console.Read();
        }
    }
}
