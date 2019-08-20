using System;

namespace Garage
{
    class Program
    {
        static void TheCars()
        {
            Car cardi = BuyACar("Black");
            cardi.NameMyCar("Cardi");
            cardi.nrDoors = 2;
            cardi.nrWheels = 4;


            Car abigail = BuyACar("Daytona Sunset");
            abigail.NameMyCar("Abigail");
            abigail.nrDoors = 2;
            abigail.nrWheels = 4;

            Car rentalCar = new Car();
            rentalCar.NameMyCar("RENTAL CAR");
            rentalCar.nrDoors = 4;
            rentalCar.nrWheels = 4;

            Car pearl = new Car("Pearl White");
            pearl.NameMyCar("Pearl");
            pearl.nrDoors = 4;
            pearl.nrWheels = 4;

            //cardi.FlatTire();
            ParkMyCar(cardi);
            ParkMyCar(abigail);
            ParkMyCar(rentalCar);
            ParkMyCar(pearl);
        }
      
        static Car BuyACar(string carColor = "silver")
        {
            Car myNewCar = new Car(carColor);
            return myNewCar;
        }

        static void ParkMyCar(Car myCar)
        {
            Console.WriteLine("Car: {0} is {1} it has {2} doors and {3} wheels",

            myCar.Name,
            myCar.color,
            myCar.nrDoors,
            myCar.nrWheels
            );
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Garage.Program.Main()");
            TheCars();

            
        }
    }
}
