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


        }
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Celica", "777GRD", "orange");

        }
    }
}
