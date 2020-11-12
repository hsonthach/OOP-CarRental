using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // VehicleFleet, Vehicle
            Vehicle newVehicle = new Vehicle("ABC123", DateTime.Now);
            Vehicle newVehicle1 = new Vehicle("DBC123", DateTime.Now);
            Vehicle newVehicle2 = new Vehicle("EBC123", DateTime.Now);
            Vehicle newVehicle3 = new Vehicle("FBC123", DateTime.Now);
            List<Vehicle> list = new List<Vehicle>();
            VehicleFleet myVehicleFleet = new VehicleFleet();

            myVehicleFleet.AddVehicleIDIntoVehicleFleet(newVehicle.getID());
            myVehicleFleet.AddVehicleIDIntoVehicleFleet(newVehicle.getID());
            myVehicleFleet.AddVehicleIDIntoVehicleFleet(newVehicle.getID());

            // Create a car 1

            // Add a car into car fleet 2

            // print list of car fleet id which has just added 


            // Create a string variable and get user input from the keyboard and store it in the variable

            while (true)
            {
                Console.WriteLine("Type 11 to Create car with  public Vehicle(string plateCode, DateTime buyDate");
                Console.WriteLine("Type 21 Add a car into car fleet");
                Console.WriteLine("Type 3  print list of car fleet id which has just added ");


                string option = Console.ReadLine();
                if (option[0] == '1')
                {
                    char cartype = option[1];

                    if (cartype == '1')
                    {
                        Console.WriteLine("Enter plate code, date will be Date.Now because of deadline ");

                        string plateCode = Console.ReadLine();
                        list.Add(new Vehicle(plateCode, DateTime.Now));
                    }
                }
                else if (option[0] == '2')
                {
                    char cartype = option[1];
                    if (cartype == '1')
                    {
                        list.ForEach(x =>
                        {
                            if (x.StoreVehicleData())
                            {
                                if (myVehicleFleet.AddVehicleIDIntoVehicleFleet(x.getID()))
                                {
                                    Console.WriteLine("Vehicle is created");
                                }
                                else
                                {
                                    Console.WriteLine("Vehicle can't be created");
                                }


                            }

                        });
                    }
                }
                else if (option[0] == '3')
                {
                    myVehicleFleet.PrintAllVehicleIDInVehicleFleet();
                }
            }


            // Print the value of the variable (userName), which will display the input value


            list.ForEach(x =>
            {
                if (x.StoreVehicleData())
                {
                    if (myVehicleFleet.AddVehicleIDIntoVehicleFleet(x.getID()))
                    {
                        Console.WriteLine("Vehicle is created");
                        myVehicleFleet.PrintAllVehicleIDInVehicleFleet();
                    }
                    else
                    {
                        Console.WriteLine("Vehicle can't be created");
                    }


                }

            });




            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

