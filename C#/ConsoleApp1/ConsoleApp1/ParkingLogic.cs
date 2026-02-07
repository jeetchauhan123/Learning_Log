using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    internal class Vehicles
    {
        public int price;
    }
    internal class Bikes : Vehicles
    {
        public Bikes()
        {
            price = 10;
        }
    }
    internal class Cars : Vehicles
    {
        public Cars()
        {
            price = 20;
        }
    }
    internal class Trucks : Vehicles
    {
        public Trucks()
        {
            price = 30;
        }
    }
    class Slot
    {
        public Vehicles VehicleType;
        public DateTime EntryTime;
    }
    internal class Start
    {
        public Action ExitAction;
        Slot[] slots = new Slot[5];
        void ParkVehicle(Vehicles vehicle)
        {
            for(int i = 0; i < slots.Length; i++)
            {
                if (slots[i] == null)
                {
                    slots[i] = new Slot
                    {
                        VehicleType = vehicle,
                        EntryTime = DateTime.Now
                    };
                    Ticket(i);
                    //Console.WriteLine($"Parked {type} at slot {i}");
                    return;
                }
            }
            Console.WriteLine("Parking Full");
        }
        void Ticket(int i)
        {
            Console.WriteLine("\n----- PARKING TICKET -----");
            Console.WriteLine($"Slot Number : {i}");
            Console.WriteLine($"Vehicle Type: {slots[i].VehicleType.GetType().Name}");
            Console.WriteLine($"Entry Time  : {slots[i].EntryTime}");
            Console.WriteLine("--------------------------\n");
        }
        void Ticket(int i, DateTime exit)
        {
            Console.WriteLine("\n----- PARKING TICKET -----");
            Console.WriteLine($"Slot Number : {i}");
            Console.WriteLine($"Vehicle Type: {slots[i].VehicleType.GetType().Name}");
            Console.WriteLine($"Entry Time  : {slots[i].EntryTime}");
            Console.WriteLine($"Exit Time   : {exit}");
            TimeSpan duration = exit - slots[i].EntryTime;
            double minutes = Math.Ceiling(duration.TotalMinutes);
            double ratePerMinute = slots[i].VehicleType.price;
            double amount = minutes * ratePerMinute;
            Console.WriteLine($"Duration    : {minutes} minutes");
            Console.WriteLine($"Rate        : ₹{ratePerMinute:F2} per minute");
            Console.WriteLine($"Total Bill  : ₹{amount:F2}");
            Console.WriteLine("--------------------------\n");
        }
        public int MainMenu()
        {
            int ch;
            Console.WriteLine("1. Park a Vehicle");
            Console.WriteLine("2. Show Slot Status");
            Console.WriteLine("3. Checkout Vehicle");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            ch = Convert.ToInt16(Console.ReadLine());
            //{ ch > 0 && ch <= 1 ? Fmenu() : ch <= 2 ? Smenu() : ch <= 3 ? Tmenu() : Exit() }
            Dictionary<int, Action> menu = new()
            {
                { 1, Fmenu },
                { 2, Smenu },
                { 3, Tmenu },
                { 4, () => ExitAction?.Invoke() }
            };

            menu.GetValueOrDefault(ch, () => Console.WriteLine("Invalid choice"))();
            return ch;
        }
        public void Fmenu()
        {
            int ch;
            Console.WriteLine("Choose a Type of vehicle");
            Console.WriteLine("1. Bike");
            Console.WriteLine("2. Car");
            Console.WriteLine("3. Truck");
            ch = Convert.ToInt16(Console.ReadLine());
            Dictionary<int, Action> park = new()
            {
                { 1, () => {
                    ParkVehicle(new Bikes());
                } },
                { 2, () => {
                    ParkVehicle(new Cars());
                } },
                { 3, () => {
                    ParkVehicle(new Trucks());
                } },
            };
            park.GetValueOrDefault(ch, () => { 
                Console.WriteLine("Invalid Choise");
            })();

        }
        public void Smenu()
        {
            Console.WriteLine();

             
            Console.WriteLine("Current slots status:");
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null)
                {
                    Console.WriteLine(
                        $"Slot {i}: {slots[i].VehicleType.GetType().Name}, Entry: {slots[i].EntryTime}"
                    );
                }
                else
                {
                    Console.WriteLine($"Slot {i}: Empty");
                }
            }
            Console.WriteLine();
        }
        public void Tmenu()
        {
            int slot;
            Console.WriteLine("Enter slot number to exit");
            slot = Convert.ToInt16(Console.ReadLine());
            if (slot < 0 || slot >= slots.Length)
            {
                Console.WriteLine("Invalid slot number");
                return;
            }
            else if (slots[slot] != null)
            {
                DateTime exitTime = DateTime.Now;
                Ticket(slot, exitTime);
                slots[slot] = null;
            }
            else
            {
                Console.WriteLine("Slot is already empty");
            }
        }
    }
    internal class ParkingLogic
    {
        private bool running = true;
        private Start start;
        public ParkingLogic()
        {
            start = new Start();
            start.ExitAction = Stop;
        }
        public void Run()
        {
            while (running)
            {
                start.MainMenu();
            }
            Console.WriteLine("Program stopped.");
        }
        public void Stop()
        {
            running = false;
        }
    }
}
