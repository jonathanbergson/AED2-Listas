using System;

namespace AED2_05_Ex02
{
    public class Stack
    {
        private Node _top;
        private int _count;
        private int _maxSize;

        public Stack(int maxSize)
        {
            _top = null;
            _maxSize = maxSize;
        }

        public void Add(Car car)
        {
            if (_count == _maxSize)
            {
                throw new Exception("[Exception] Stack is full");
            }

            Node newNode = new Node(car, _top);
            _top = newNode;
            _count++;
        }

        public Car Pop()
        {
            if (_top == null)
            {
                throw new Exception("[Exception] Stack is empty");
            }

            Car removed = _top.Car;
            _top = _top.Next;
            _count--;
            return removed;
        }

        public bool Find(string plate)
        {
            bool founded = false;

            Node current = _top;
            while (current != null)
            {
                if (current.Car.Plate == plate)
                {
                    founded = true;
                    break;
                }
                current = current.Next;
            }

            return founded;
        }

        public void Show()
        {
            int position = 1;
            Node current = _top;
            while (current != null)
            {
                Console.WriteLine($"\t {position}. {current.Car.Plate}");

                position++;
                current = current.Next;
            }
        }
    }
}
