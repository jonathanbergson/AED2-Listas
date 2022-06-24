using System;

namespace AED2_05_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            Parking parking = new Parking(3);

            Console.WriteLine();
            car = new Car("UNO-1234");
            parking.Add(car);
            car = new Car("PAL-1234");
            parking.Add(car);
            car = new Car("MOB-1234");
            parking.Add(car);
            parking.ShowSpaces();

            parking.Remove("PAL-1234");
            parking.Remove("MOB-1234");
            parking.ShowSpaces();
        }
    }
}
