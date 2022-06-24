namespace AED2_05_Ex02
{
    public class Node
    {
        public Car Car { get; }
        public Node Next { get; }

        public Node(Car car, Node next)
        {
            Car = car;
            Next = next;
        }
    }
}
