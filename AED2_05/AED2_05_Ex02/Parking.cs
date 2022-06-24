using System;
using System.Net.Sockets;

namespace AED2_05_Ex02
{
    public class Parking
    {
        private Stack _spaces;
        private Stack _maneuevers;

        public Parking(int maxSize)
        {
            _spaces = new Stack(maxSize);
            _maneuevers = new Stack(maxSize);
        }

        public void Add(Car car)
        {
            try
            {
                _spaces.Add(car);
                Console.WriteLine($"\t{car.Plate} is park.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\tParking is full! {car.Plate} is gone.");
            }
        }

        public void Remove(string plate)
        {
            if (_spaces.Find(plate))
            {
                Car current = _spaces.Pop();
                while (current.Plate != plate)
                {
                    Maneuver(current);
                    current = _spaces.Pop();
                }

                Console.WriteLine($"\t{current.Plate} is gone. It was maneuvered {current.Moved} times.");
                ManeuverBack();
            }
            else
            {
                Console.WriteLine($"\t{plate} not found.");
            }
        }

        private void Maneuver(Car car)
        {
            car.Move();
            _maneuevers.Add(car);
        }

        private void ManeuverBack()
        {
            bool maneuvering = true;

            while (maneuvering)
            {
                try
                {
                    Car car = _maneuevers.Pop();
                    _spaces.Add(car);
                }
                catch (Exception e)
                {
                    maneuvering = false;
                }
            }
        }

        public void ShowSpaces()
        {
            Console.WriteLine("\n\tSpaces:");
            _spaces.Show();
            Console.WriteLine();
        }

        public void ShowManeuevers()
        {
            Console.WriteLine("\n\tManeuevers:");
            _maneuevers.Show();
            Console.WriteLine();
        }
    }
}
