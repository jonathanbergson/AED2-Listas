namespace AED2_05_Ex01
{
    internal class Node
    {
        public char Character { get; }
        public Node Next { get; }

        public Node(char character, Node next)
        {
            Character = character;
            Next = next;
        }
    }
}
