using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class Mission
    {
        public virtual void Objective()
        {
            Console.WriteLine("Default: reason for location\r\nPress Enter:");
            Console.ReadLine();
           
        }
        public virtual void Location()
        {
            Console.WriteLine("Battle Zone\r\nPress Enter:");
            Console.ReadLine();
        }     
        public virtual void TimeOfBattle()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Right now local time is {now}, and the battle is starting.\r\nPress Enter:");
            Console.ReadLine();
        }
    }
    class Air : Mission
    {
        public override void Location()
        {
            Console.WriteLine("There is a fierce fight in the air!!!!" +
                              " Our fierce pilots are diving and maneuvering out of danger!!!!\r\nPress Enter: ");
            Console.WriteLine();    
            Console.ReadLine();

        }
        public override void Objective()
        {

            Console.WriteLine("Our objective is to keep enemy planes out of American airspace!!!\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void TimeOfBattle()
        {
            DateTime now = DateTime.UtcNow;
            Console.WriteLine($"The battle begins when radars pickup enemy aircraft at {now} zulu time!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();
        }
    }
    class Land : Mission
    {
        public override void Location()
        {
            Console.WriteLine("The battle on land is beginning to rage!!!!! It takes place at the capitol city of the enemy.\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void Objective()
        {
            Console.WriteLine($"Our objective is to make sure that the allies protect the hospital.\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void TimeOfBattle()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine($"Scouts locate the enemy advancing local time at {now}.\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();

        }
    }
    class Sea : Mission
    {
        public override void Location()
        {
            Console.WriteLine("On the deep blue sea, the fleet is on high alert!!!!!\r\nPress Enter:");
            Console.ReadLine();
            //Ship shipinabattle = new Ship();
            //Console.WriteLine($"Here comes the {shipinabattle}");
        }

        public override void Objective()
        {
            Console.WriteLine("The objective is to protect the blockade of ships around America.\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void TimeOfBattle()
        {
            DateTime now = DateTime.UtcNow;

            Console.WriteLine($"Enemy ships are spotted in American waters at " +
                              $"approximately {now} zulu time.\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine("Let's see how our vehicle unit is fairing....");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
