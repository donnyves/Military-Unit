using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class Personnel
    {
        public void Muster()
        {
            Console.WriteLine("Reports for duty");
        }
        public virtual void ReceivesOrders()
        {
            Console.WriteLine($"Default: Obeys the orders.");
        }
        public virtual void DisobeysOrders()
        {
            Console.WriteLine($"Default:  Refuses to work");
        }
        public virtual void GoesOnMission()
        {
            Console.WriteLine($"Default: Goes on mission");
        }  
    }
    class Officer : Personnel
    {
        public override void ReceivesOrders()
        {
            Console.WriteLine("The leadership gets orders from the Admiral\r\nPress Enter:");
            Console.ReadLine();
           

        }
        public void GivesOrders()
        {
            Console.WriteLine("The Ensign screams, Do this!! Do that!!!\r\nPress Enter:");
            Console.ReadLine();

        }
        public void PlansMission()
        {
            Console.WriteLine("The Officers are planning the mission based on objectives.\r\nPress Enter:");
            Console.ReadLine();

        }
        public void DoesPaperWork()
        {
            Console.WriteLine("The Officers are doing paperwork.....\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void DisobeysOrders()
        {
            Console.WriteLine("A particular officer is having trouble obeying orders.\r\nPress Enter:.");
            Console.ReadLine();
            string calibrations = "You have been awarded another chance, but this will be reflected poorly on your annual evaluation.";
            string correction = "You have been sent to the brig, now you are being fed bread and water.";

            Console.WriteLine("Who do you think your are?!!!! Are you going to comply or not!, type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{calibrations}\r\nPress Enter:");
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{correction}\r\nPress Enter:");
                Console.ReadLine();

            }
            Console.WriteLine();

        }
        public override void GoesOnMission()
        {
            Console.WriteLine("The Officers are making sure everone completes the mission\r\nPress Enter:");
            Console.WriteLine();
            Console.ReadLine();
            string nice = "You are so brave to go on this mission, you're making your country proud!!!!";
            string mean = "You're going on this mission whether you like it or not, coward!!!!";

            Console.WriteLine("Do you accept this mission? , type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{nice}\r\nPress Enter:");
                Console.WriteLine();
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{mean}\r\nPress Enter:");
                Console.ReadLine();

            }
            Console.Clear();
        }
    }
    class Enlisted : Personnel
    {
        public override void ReceivesOrders()
        {
            Console.WriteLine("The Senior enlisted just got the orderes, " +
                              "now they are passing down the word from leadership.\r\nPress Enter:");
            Console.ReadLine();

        }
        public void DoesAllTheWork()
        {
            Console.WriteLine("Follows orders and completes the tasks\r\nPress Enter:");
            Console.ReadLine();

        }
        public void LoadsEquipment()
        {
            Console.WriteLine("Loading and transporting equipment\r\nPress Enter:");
            Console.ReadLine();

        }
        public override void DisobeysOrders()
        {
            Console.WriteLine("There's a Third Class Petty Officer, hiding in the " +
                              "storage container while everyone works.\r\nPress Enter:");
            Console.ReadLine();
            string good ="You remember the time this person threw you under the bus, you tell you superiors immediately." ;
            string bad = "This 3rd class knows what you did last summer, you decide to sweep this incident under the rug.";

            Console.WriteLine("Do you want to report this incident?, type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{good}\r\nPress Enter:");
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{bad}\r\nPress Enter:");
                Console.ReadLine();

            }
            Console.WriteLine();

        }
        public override void GoesOnMission()
        {
            Console.WriteLine("Now, your are on the mission.\r\nPress Enter:");
            Console.ReadLine();

        }
        public void FightsInBattle()
        {

            Console.ReadLine();
            Console.WriteLine("Time to fight in the battle, report to your division!!.\r\nPress Enter:");
            Console.Clear();
        }

    }
    
}
