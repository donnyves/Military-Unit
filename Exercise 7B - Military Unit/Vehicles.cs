using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class Vehicles
    {
        public void EngineStart()
        {
            Console.WriteLine($"Engine Starting: ");
        }
        public void EngineStops()
        {
            Console.WriteLine($"Enginge Stopping: ");
        }
        public void Maintenance()
        {
            Console.WriteLine("Performing maintenance and now you're good to go!");
        }
        public virtual void Move()
        {
            Console.WriteLine("Default: Vehicle is moving");
        }
        public virtual void Operating()
        {
            Console.WriteLine("Default: Vehicle is being operated.");
        }
        

    }
    class HumVee : Vehicles
    {
        public void Accelerate()
        {
            Maintenance();
            Console.WriteLine();
            Console.WriteLine("You accelerating to the frontlines with urgency!!\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
        }
        public void Brakes()
        {
            Console.WriteLine("You have come to a complete stop. Assess the situation.\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
        }
        public override  void Move()
        {
            string notStuck = "You have reached the frontline with your Humvee with no issues.";
            string Stuck = "You're stuck in the mud, you're probably not going to make it";

            Console.WriteLine("Did you take the advice of the local ally rebels, type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{notStuck}\r\nPress Enter:");
                Console.ReadLine();
                Console.WriteLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{Stuck}\r\nPress Enter:");
                Console.ReadLine();
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine("Driving through rough terrain");
            Console.Clear();
        }
        public override void Operating()
        {
            Console.WriteLine("Using to the steering wheel to turn.");
        }
        
    }
    class Helicopter : Vehicles
    {
        
        public void TakesOff()
        {
            EngineStart();
            Console.WriteLine();
            string safeTakeOff = "You had had a successful takeoff!! Now get those bad guys ";
            string unSafeTakeoff = "Maintenance was not done properly, you're a sitting duck!!!!!";

            Console.WriteLine("Was your takeoff successful? , type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{safeTakeOff}\r\nPress Enter:");
               
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{unSafeTakeoff}\r\nPress Enter:");
                
            }
            Console.WriteLine();
            Console.WriteLine("Taking Off....\r\nPressEnter:");
            Console.ReadLine();
        }
        public void Lands()
        {
            Console.WriteLine("You have landed successfully, that was a close one!\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();

        }
        public override void Move()
        {
            Console.WriteLine("Your helicopter is flying through the air..Watch out for anti-aircraft fire!!!!!\r\nPress Enter:");
            Console.ReadLine();
        }
        public override void Operating()
        {
            Console.WriteLine("Checking altitide, pitch and yaw.\r\nPress Enter:");
            Console.ReadLine();

        }

    }
    class Ship : Vehicles
    {
        //Weapon shipWeapon;
        //public Ship() {  }
        //public Ship(Weapon shipWeapon)
        //{
        //    this.shipWeapon = shipWeapon;
        //} 
        public void MoorsToPier()
        {
            Console.WriteLine("The ship is moored to the pier,and you're saying goodbye to all your friends and family.\r\nPress Enter:");
            Console.ReadLine();
        }
        public void LeavesPeir()
        {
            Console.WriteLine("You're leaving the pier and you're wiping away your tears.\r\nPress Enter:");
            Console.ReadLine();
        }
        public override void Move()
        {
            Console.WriteLine("Your're Sailing on the deep blue sea!!!!\r\nPress Enter:");
            Console.ReadLine();
        }
        public override void Operating()
        {
            string properMaint = "Looks like everything is working properly and your on scedule.";
            string noMaint = "Gun decking rears its ugly head again.  The navigation systems are off,\r\n " +
                             "and you just crashed into an outcropping of jagged rocks";

            Console.WriteLine("Did the crew conduct proper maintence on the navigation system? , type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{properMaint}\r\nPress Enter:");
               
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{noMaint}");
                Console.WriteLine();
                EngineStops();
                Console.WriteLine();
                Maintenance();
                Console.WriteLine("Press Enter:");
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

        }

       
    }
    class DeathStar : Vehicles
    {
        public void CreatesOwnGravity()
        {
            Console.WriteLine("The shear size of the Death Star is attracting nearby asteroids\r\nPress Enter:");
            Console.ReadLine();
        }
        public void TractorBeam()
        {
            Console.WriteLine("Everyone man the Tractor Beam!!!!");
            Console.WriteLine();
            string capture = "You were able to move the asteroid out of the way, and you have been awarded with a new shiny medal!!!";
            string escape = "You have been force choked and shamed by your peers.";

            Console.WriteLine("Were you able to escape the rebels?; type yes or no?");
            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine($"{capture}\r\nPress Enter:");
                Console.ReadLine();
            }
            else if (userInput == "no")
            {
                Console.WriteLine($"{escape}");
                Console.WriteLine();
                Maintenance();
                Console.WriteLine();
                Console.WriteLine("Press Enter:");
                Console.ReadLine();

            }
        }
        public override void Move()
        {
            Console.WriteLine("The Death Star has entered hyperSpace\r\nPress Enter:");
            Console.ReadLine();
        }
        public override void Operating()
        {
            Console.WriteLine("Enters Wormhole\r\nPress Enter:");
            Console.WriteLine();
            Console.WriteLine("Time to check on our weapons........");
            Console.ReadLine();
            Console.Clear();
        }
    }

}
