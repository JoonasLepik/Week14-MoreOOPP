using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string markName;
            string modelName;
            string registrationNumber;
            string color;
            int fuelTank;
            int odometer;

            public Car(string _name, string _markName, string _color, string _regNumb) //Constuctor
            {
                markName = _markName;
                modelName = _name;
                registrationNumber = _regNumb;
                color = _color;
                fuelTank = 60;
                odometer = 0;
                Console.WriteLine($"{markName} {modelName} {registrationNumber} {color} has been created.");
            }
            public void ShowCarData()
            {
                Console.WriteLine($"MarkName: {markName}");
                Console.WriteLine($"modelName: {modelName}");
                Console.WriteLine($"registrationNumber: {registrationNumber}");
                Console.WriteLine($"color: {color}");
                Console.WriteLine($"fuel: {fuelTank}");
                Console.WriteLine($"odometer: {odometer}");
            }
            public void Drive()
            {
                fuelTank -= 5;
                odometer += 100;
                Console.WriteLine("Vroom-Vroom");
            }
            public int FuelTank
            {
                get { return fuelTank;  }
            }
            public int Odometer
            {
                get { return odometer; }
            }
            public string Color
            {
                get { return color; }
            }
            public string RegistrationNumber
            {
                get { return registrationNumber; }
            }
            public string ModelName
            {
                get { return modelName; }
            }
            public string MarkName
            {
                get { return markName; }
            }


        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Celica", "777GRD", "Orange");
            while (myCar.FuelTank > 0)
            {
                myCar.Drive();
            }
            myCar.ShowCarData();
        }
    }
}
