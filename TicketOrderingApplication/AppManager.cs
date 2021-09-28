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
        private const string Separator = "========================================================";
        private VehicleFactory _factory;

        public AppManager()
        {
            _factory = new VehicleFactory();
        }

        public void MainMenuLoop()
        {
            bool isBuyingTicket = true;
            while (isBuyingTicket)
            {
                PrintWelcomeScreen();
                string company = SelectCompany();
                Vehicle vehicle = SelectVehicleType(company);
                GetVehicleDataInput(vehicle);
                Console.Clear();
                Console.WriteLine("Thank you for your purchase.");
                Console.WriteLine("Your order: " + vehicle.ToString());
                Console.ReadLine();
                Console.WriteLine("Would you like to buy another ticket?" +
                                  "\nEnter Y for yes. Otherwise the system will terminate.");
                string input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    isBuyingTicket = false;
                }
            }
        }

        private void PrintWelcomeScreen()
        {
            Console.WriteLine(Separator);
            Console.WriteLine("\tWelcome to the ticket ordering system");
            Console.WriteLine(Separator);
            Console.WriteLine("\nPress any key to proceed.");
            Console.ReadKey();
        }

        private string SelectCompany()
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine("\tSelect a company");
            Console.WriteLine(Separator);
            Console.WriteLine("\nSelect the company by pressing the corresponding number and enter?");
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

        public void GetVehicleDataInput(Vehicle vehicle)
        {
            Console.Clear();
            Console.WriteLine(Separator);
            Console.WriteLine($"\tTrip details");
            Console.WriteLine(Separator);

            vehicle.LicensePlate = SetVehiclesLicensePlate(vehicle);
            vehicle.Date = ParsedDate();
            vehicle.HasBrobizz = CheckForBroBizz();
        }

        private string SetVehiclesLicensePlate(Vehicle vehicle)
        {
            Console.WriteLine("Enter the vehicles license plate. It must not be longer than 7 characters.");
            bool isValidLicensePlate = false;
            string plateNumber = "";
            while (!isValidLicensePlate)
            {
                try
                {
                    vehicle.LicensePlate = Console.ReadLine();
                    if (!string.IsNullOrEmpty(vehicle.LicensePlate) && !string.IsNullOrWhiteSpace(vehicle.LicensePlate))
                    {
                        isValidLicensePlate = true;
                        plateNumber = vehicle.LicensePlate;
                    }

                    Console.WriteLine("You have to specify a license plate number.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Please try again: ");
            }
            return plateNumber;
        }

        private DateTime ParsedDate()
        {
            DateTime date = new DateTime();
            bool tryParse = true;
            while (tryParse)
            { 
                Console.WriteLine("Enter the date in DD.MM.YYYY format.");
                string dateInput = Console.ReadLine();
                try
                {
                    date = DateTime.Parse(dateInput);
                    if (date > DateTime.Now)
                    {
                        tryParse = false;
                    }
                    else
                    {
                       Console.WriteLine("You can't buy tickets for the past."); 
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine($"The date was in wrong format: {dateInput}");
                    Console.WriteLine("Please try again.");
                }
            }
            return date;
        }

        private bool CheckForBroBizz()
        {
            Console.WriteLine("Are you using a BroBizz? If you do, press Y for yes.");
            string bizzInput = Console.ReadLine();
            if (bizzInput.ToLower() == "y")
            {
                return true;
            }
            return false;
        }


        


    }
}
