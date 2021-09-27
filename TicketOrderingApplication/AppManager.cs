using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;
using StoreBaeltTicketLibrary;

namespace TicketOrderingApplication
{
    public class AppManager
    {
        private const string Separator = "====================================";
        private VehicleFactory _factory;

        public AppManager()
        {
            _factory = new VehicleFactory();
        }

        public void MainMenuLoop()
        {
            bool buyTicket = true;
            while (buyTicket)
            {
                PrintWelcomeScreen();
                string company = SelectCompany();
                Vehicle vehicle = SelectVehicleType(company);
                GetVehicleData(vehicle);
                Console.WriteLine("Thank you for your purchase.");
                Console.WriteLine(vehicle);
                Console.ReadLine();

                Console.WriteLine("Would you like to buy another ticket?" +
                                  "Enter Y for yes. Otherwise the system will terminate.");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    buyTicket = false;
                }
            }
        }

        private void PrintWelcomeScreen()
        {
            Console.WriteLine(Separator);
            Console.WriteLine("\tWelcome to the ticket ordering system");
            Console.WriteLine(Separator);
            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadLine();
        }

        private string SelectCompany()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("\tSelect a company");
            Console.WriteLine(Separator);
            Console.WriteLine("\nSelect the vehicle type by pressing the corresponding number and enter?");
            Console.WriteLine("\t1. Storebaelt");
            Console.WriteLine("\t2. Oresund");
            string company = "";
            bool shouldLoop = true;
            while (shouldLoop)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        company = "Storebaelt";
                        shouldLoop = false;
                        break;
                    case "2":
                        company = "Oresund";
                        shouldLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input try again.");
                        break;
                }
            }
            return company;
        }

        private Vehicle SelectVehicleType(string company)
        {
            PrintVehicleMenu(company);
            bool shouldLoop = true;
            Vehicle vehicle = null;
            while (shouldLoop)
            {
               string input = Console.ReadLine();
               switch (input)
               {
                    case "1":
                        vehicle = _factory.CreateCar(company);
                        shouldLoop = false;
                        break;
                    case "2":
                        vehicle = _factory.CreateMc(company);
                        shouldLoop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input try again.");
                        break;
               }
            }
            return vehicle;
        }

        private void PrintVehicleMenu(string company)
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine($"\t{company}");
            Console.WriteLine(Separator);
            Console.WriteLine("\nSelect the vehicle type by pressing the corresponding number and enter?");
            Console.WriteLine("\t1. Car");
            Console.WriteLine("\t2. Motorcycle");
        }

        public void GetVehicleData(Vehicle vehicle1)
        {
            Vehicle vehicle = vehicle1;
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine($"\tTrip details");
            Console.WriteLine(Separator);
            Console.WriteLine("Enter the vehicles license plate. It must not be longer than 7 characters.");

            bool isValidLicensePlate = false;
            while (!isValidLicensePlate)
            {
                try
                {
                    vehicle.LicensePlate = Console.ReadLine();
                    isValidLicensePlate = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("Enter the date in DD.MM.YYYY format.");
            string dateInput = Console.ReadLine();
            DateTime date = DateTime.Parse(dateInput);
            vehicle.Date = date;

            Console.WriteLine("Are you using a BroBizz? If you do, press Y for yes.");
            string bizzInput = Console.ReadLine();
            if (bizzInput.ToLower() == "y")
            {
                vehicle.HasBrobizz = true;
            }
            
        }


        


    }
}
