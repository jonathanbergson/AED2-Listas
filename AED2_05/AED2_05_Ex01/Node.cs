namespace AED2_05_Ex01
{
    class Node
    {
        public char Character { get; }
        public Node Next { get; }

        public Node(char charater, Node next)
        {
            Character = charater;
            Next = next;
        }
    }
}
