using System;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        int NumberOfWheels { get; set; }
        string Color { get; set; }
        int NumberOfDoors { get; set; }
        string Model { get; set; }

        void DisplayDetails();
    }

    public interface ICompany
    {
        string Logo { get; set; }
        string Headquarters { get; set; }
    }

    public class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Headquarters { get; set; }

        public bool HasTrunk { get; set; }
        public int TrunkCapacity { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details:\nModel: {Model}\nColor: {Color}\nWheels: {NumberOfWheels}\nDoors: {NumberOfDoors}\nTrunk: {HasTrunk}\nTrunk Capacity: {TrunkCapacity} liters\nCompany: {Logo}\nHeadquarters: {Headquarters}");
        }
    }

    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Headquarters { get; set; }

        public int CargoCapacity { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Truck Details:\nModel: {Model}\nColor: {Color}\nWheels: {NumberOfWheels}\nDoors: {NumberOfDoors}\nCargo Capacity: {CargoCapacity} kg\nFour-Wheel Drive: {HasFourWheelDrive}\nCompany: {Logo}\nHeadquarters: {Headquarters}");
        }
    }

    public class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string Headquarters { get; set; }

        public int NumberOfSeats { get; set; }
        public bool HasSunroof { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"SUV Details:\nModel: {Model}\nColor: {Color}\nWheels: {NumberOfWheels}\nDoors: {NumberOfDoors}\nSeats: {NumberOfSeats}\nSunroof: {HasSunroof}\nCompany: {Logo}\nHeadquarters: {Headquarters}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car instance and set its properties
            Car car = new Car
            {
                NumberOfWheels = 4,
                Color = "Red",
                NumberOfDoors = 4,
                Model = "Sedan",
                Logo = "Toyota",
                Headquarters = "Japan",
                HasTrunk = true,
                TrunkCapacity = 500
            };

            // Create a Truck instance and set its properties
            Truck truck = new Truck
            {
                NumberOfWheels = 4,
                Color = "Blue",
                NumberOfDoors = 2,
                Model = "Pickup",
                Logo = "Ford",
                Headquarters = "USA",
                CargoCapacity = 1000,
                HasFourWheelDrive = true
            };

            // Create an SUV instance and set its properties
            SUV suv = new SUV
            {
                NumberOfWheels = 4,
                Color = "Black",
                NumberOfDoors = 4,
                Model = "Crossover",
                Logo = "Honda",
                Headquarters = "Japan",
                NumberOfSeats = 7,
                HasSunroof = true
            };

            // Display details of each vehicle
            car.DisplayDetails();
            Console.WriteLine();

            truck.DisplayDetails();
            Console.WriteLine();

            suv.DisplayDetails();

            Console.ReadLine();
        }
    }
}
