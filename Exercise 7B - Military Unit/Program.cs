using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_7B___Military_Unit
{
    class Program
    {
        static void DoWork()
        {

            //--------------------------------------- Personnel--------------------------------------------------------------------------------
            Console.WriteLine("Get ready for an amazing adventure!!!!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.WriteLine("You're about to take the personnel, vehicles, and weapons through a journey of a lifetime!!!\r\nPress Enter:");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Our fine service members are trained and ready to fight!!!!!!");
            Console.WriteLine();
            Personnel myPersonnel = new Personnel();

            //myPersonnel.Muster();
            //myPersonnel.ReceivesOrders();
            //myPersonnel.DisobeysOrders();
            //myPersonnel.GoesOnMission();

            Officer myOfficer = new Officer();
            myOfficer.ReceivesOrders();
            myOfficer.DoesPaperWork();
            myOfficer.PlansMission();
            myOfficer.GivesOrders();
            myOfficer.DisobeysOrders();
            myOfficer.GoesOnMission();

            Enlisted myEnlisted = new Enlisted();
            myEnlisted.ReceivesOrders();
            myEnlisted.DoesAllTheWork();
            myEnlisted.LoadsEquipment();
            myEnlisted.DisobeysOrders();
            myEnlisted.GoesOnMission();
            myEnlisted.FightsInBattle();

            //----------------------------------------Mission---------------------------------------------------------------------------------------------

            Console.WriteLine("We are about to embark on a dangerous mission!!!");
            Mission myMission = new Mission();
            Console.WriteLine();

            //myMission.Objective();
            //myMission.Location();
            //myMission.TimeOfBattle();

            Air myAir = new Air();
            myAir.Objective();         
            myAir.Location();
            myAir.TimeOfBattle();


            Land myLand = new Land();
            myLand.Objective();
            myLand.Location();
            myLand.TimeOfBattle();

            Sea mySea = new Sea();
            mySea.Location();
            mySea.Objective();
            mySea.TimeOfBattle();

            //---------------------------------------Vehicle--------------------------------------------------------------------------------------------

            Console.WriteLine("Let's see what the vehicle unit is up to, humvees, ships, and a Death Star?!!");
            Console.WriteLine();
            Vehicles myVehicles = new Vehicles();

            //myVehicles.EngineStart();
            //myVehicles.EngineStart();
            //myVehicles.Maintenance();
            //myVehicles.Move();
            //myVehicles.Operating();

            Console.WriteLine("Here comes the Humvee unit rolling in!!!");
            Console.WriteLine();
            HumVee myHumVee = new HumVee();
            myHumVee.Accelerate();
            myHumVee.Operating();
            myHumVee.Brakes();
            myHumVee.Move();
            Console.WriteLine();

            Console.WriteLine("Look in the sky!!! Here comes our fierce helicopter unit.");
            Console.WriteLine();
            Helicopter myHelicopter = new Helicopter();
            myHelicopter.TakesOff();
            myHelicopter.Operating();
            myHelicopter.Move();
            myHelicopter.Lands();
            Console.WriteLine();

            Console.WriteLine("Hooyah!!! Look at that fine ship!!!");
            Console.WriteLine();
            Ship myShip = new Ship();
            myShip.MoorsToPier();
            myShip.LeavesPeir();
            myShip.Move();
            myShip.Operating();      
            Console.WriteLine();


            Console.WriteLine("Part of the rebel alliance and a traitor?  Watch out for the Death Star!!");
            Console.WriteLine();
            DeathStar myDeathStar = new DeathStar();
            myDeathStar.CreatesOwnGravity();
            myDeathStar.TractorBeam();
            myDeathStar.Move();
            myDeathStar.Operating();
            Console.WriteLine();

            //----------------------------------------Weapon------------------------------------------------------------------------------------------------

            Console.WriteLine("Welcome to the Weapon Arsenal! Get ready for a fight!!!!");
            Weapon myWeapon = new Weapon();

            //myWeapon.Shoots();
            //myWeapon.Reloads();
            //myWeapon.MoraleBoost();
            //myWeapon.mount();
            //myWeapon.StoredSecurely();
            Console.WriteLine();

            Console.WriteLine("Here comes the bomb unit!");
            Console.WriteLine();
            BombWeapon myBombWeapon = new BombWeapon();
            myBombWeapon.Shoots();
            Console.WriteLine();
            myBombWeapon.BlowsUp();
            myBombWeapon.Reloads();
            Console.WriteLine();
            myBombWeapon.HeatSeaking();
            myBombWeapon.MoraleBoost();
            myBombWeapon.StoredSecurely();
            Console.WriteLine();

            Console.WriteLine("These are the actions of Small Arms unit:");
            Console.WriteLine();
            SmallArmsWeapon mySmallArmsWeapon = new SmallArmsWeapon();
            mySmallArmsWeapon.CarriedOnPerson();
            mySmallArmsWeapon.mount();
            Console.WriteLine();
            mySmallArmsWeapon.Shoots();
            mySmallArmsWeapon.CleanedEverday();
            mySmallArmsWeapon.MoraleBoost();
            Console.WriteLine();

            Console.WriteLine("Here comes the Death Star with its giant laser!!!!!!");
            Console.WriteLine();
            LaserWeapon myLaserWeapon = new LaserWeapon();
            myLaserWeapon.mount();
            Console.WriteLine();
            myLaserWeapon.Shoots();
            myLaserWeapon.DestroysAlderan();
            myLaserWeapon.EmitsLightWaves();
            myLaserWeapon.MoraleBoost();
            myLaserWeapon.StoredSecurely();          
            myWeapon.GameOver();
        }
        static void Main(string[] args)
        {
            DoWork();
        }
    }
}
