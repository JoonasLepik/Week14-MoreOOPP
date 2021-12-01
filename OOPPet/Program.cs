using System;

namespace OOPPet
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;
            public Pet(string _name) //Constuctor
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congrations! you have adopted {name}!");

            }
            // getters for class properties
            public string Name
            {
                get { return name; }

            }
            public double Weight
            {
                get { return weight; }

            }

            public void ShowPetData()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Weight: {weight}");
                Console.WriteLine($"Age: {age}");
            }
            public void Eat()
            {
                weight += 0.2; //happiness = happiness + 0.2
            }
            public void Exesise()
            {
                Console.WriteLine("The hamster is runing around it's cage.");
                weight -= 0.1;
            }
            public void Rename(string newName)
            {
                name = newName;
            }
            public void GetOlder()
            {
                age++;
            }
        }



        static void Main(string[] args)
        {
            Pet myHamster = new Pet("Hamster");
            myHamster.ShowPetData();
            Console.WriteLine("Please enter an new name to rename your hamster:");
            string userInput = Console.ReadLine();
            myHamster.Rename(userInput);
            Console.WriteLine($"Name: {myHamster.Name}");
            for (int i = 1; i < 10; i++)
            {
                myHamster.Eat();
                Console.WriteLine($"Current weight: {myHamster.Weight}");
                while(myHamster.Weight > 0.7)
                {
                    myHamster.Exesise();
                }

                /*if(myHamster.Weight > 0.7)
                {
                    myHamster.Exesise();
                }*/
                myHamster.GetOlder();
            }
            myHamster.ShowPetData();
            Console.WriteLine("We cant help you no longer.");
        }    
    }
}
