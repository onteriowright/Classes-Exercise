using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFordBronco = new Car(0, "Ford", "Bronco", 1982);

            Car mySubaru = new Car(0)
            {
                Make = "Subaru",
                Model = "Forrester",
                Year = 1999
            };

            Console.WriteLine(mySubaru.Description);
            Console.WriteLine(myFordBronco.Description);

            myFordBronco.Drive(9999);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Drive(70);

            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);

        }
    }
}