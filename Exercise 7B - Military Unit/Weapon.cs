using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7B___Military_Unit
{
    class Weapon
    {

        public virtual void Shoots()
        {
            Console.WriteLine($"Default: Shooting Sound");
        }
        public void Reloads()
        {
            Console.WriteLine($"Reload Sound....:");
        }
        public virtual void MoraleBoost()
        {
            Console.WriteLine("Default: Your just recieved an award as result of your subordinates hard work!");
        }
        public virtual void mount()
        {
            Console.WriteLine($"Mounted:");
        }
        public virtual void StoredSecurely()
        {
            Console.WriteLine($"Weapon stored Safe:");
        }
        public virtual void GameOver()
        {
            Console.WriteLine("You made it!!!! You have won the war!!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine("GAME OVER!!\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();
        }
    }

    class BombWeapon : Weapon
    {
        public override void Shoots()
        {
            Console.WriteLine("Ordinance gets launched");
        }

        public void BlowsUp()
        {
            string bombsound = " ";
            Console.WriteLine("Choose a sound for your bomb: ");
            bombsound = (Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"When your bomb landed, it made a {bombsound} sound!!!!!");
            Console.WriteLine();
        }
        public void HeatSeaking()
        {
            int targetsDestroyed;
            Console.WriteLine("Missle launched, how many targets destroyed? Enter an integer(whole number): ");
            targetsDestroyed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"When your {targetsDestroyed} bombs when off, {targetsDestroyed * 2} targets were destroyed\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
        }
        public override void MoraleBoost()
        {
            Console.WriteLine("Loading shiny new bombs in the plane\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
        }
        public override void StoredSecurely()
        {
            Console.WriteLine("You stored the bombs and missles away with pride.\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
        }
    }

    class SmallArmsWeapon : Weapon
    {
        
        public void CarriedOnPerson()
        {
            string posControl = "You have positive control of your weapon.  You're getting a promotion!!!";
            string lostWeapon = "You're going to be court martialed.";
            Console.WriteLine("Do you have possesion of your weapon, type yes or no?");
            string weaponPos = Console.ReadLine();

            if (weaponPos == "yes")
            {
                Console.WriteLine($"{posControl}\r\nPress Enter twice:");
                Console.ReadLine();
            }
            else

                Console.WriteLine($"{lostWeapon}\r\nPress Enter twice:");
            Console.ReadLine();

            Console.WriteLine();
        }
        public override void mount()
        {
            Console.WriteLine("Your dug in and you're ready fight!!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
             
        }
        public override void Shoots()
        {
            Console.WriteLine("You shooting your rifle and dodging bullets....... BRAT BRAT BRAT!!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();
        }

        public void CleanedEverday()
        {
            Console.WriteLine("Cleaning Weapon........\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine();           
        }

        public override void StoredSecurely()
        {
            Console.WriteLine("Your weapon is safely secured under your cot.\r\nPress Enter:");
            Console.ReadLine();
          
        }
        public override void MoraleBoost()
        {
            Console.WriteLine("You just got a fresh crate of ammo!!\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();
       
        }


    }

    class LaserWeapon : Weapon
    {
        public override void mount()
        {
            Console.WriteLine("The Death Star Cannon is mounted properly.");
            Console.WriteLine();
        }
        public override void Shoots()
        {
            Console.WriteLine("Shooting weapon: BEEEEEEAAAAAAAAAAMMMMM");
            Console.WriteLine();
        }
        public void DestroysAlderan()
        {       
            Console.WriteLine("What was the sound did the people of Alderan make, before their planet blew up? ");
            string cries = (Console.ReadLine());
            Console.WriteLine($" The people of Alderan cried out {cries}!!!!!!!!!!!!!\r\nPress Enter: ");
            Console.ReadLine();
            Console.WriteLine();
        }
        public void EmitsLightWaves()
        {
            Console.WriteLine("Narrow Beam Created.");
            Console.WriteLine();
        }
        public override void StoredSecurely()
        {
            Console.WriteLine("The Death Star cannon was properly put away\r\nPress Enter:");
            Console.WriteLine();
            Console.Clear();

        }
        public override void MoraleBoost()
        {
            Console.WriteLine("The rebels can't escape the laser blast!");
            Console.WriteLine();
        }

    }
}
