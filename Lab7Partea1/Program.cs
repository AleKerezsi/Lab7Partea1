using System;

namespace Lab7Partea1
{
    class Program
    {
        /*
        In metoda Main, creati autoturisme si
        afisati-le descrierea 
        */
        static void Main(string[] args)
        {
            Motor motor1 = new Motor(3500, 120, "benzina");
            Motor motor2 = new Motor(2200, 110, "diesel");
            Motor motor3 = new Motor(1500, 80, "benzina");

            Autoturism autoturism1 = new Autoturism(motor1, 5, "Seat", "Leon", 2012);
            Autoturism autoturism2 = new Autoturism(motor2, 3, "Volkswagen", "Passat", 2016);
            Autoturism autoturism3 = new Autoturism(motor3, 5, "Dacia", "Logan", 2010);

            Console.WriteLine(autoturism1.GetDescription());
            Console.WriteLine(autoturism2.GetDescription());
            Console.WriteLine(autoturism3.GetDescription());

        }
    }
}
