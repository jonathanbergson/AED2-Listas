namespace AED2_Lista03
{
    class Node
    {
        Score score;
        Node next;

        public Score Score
        {
            get => score;
            set => score = value;
        }

        public Node Next
        {
            get => next;
            set => next = value;
        }

        public Node(Score score, Node next)
        {
            this.score = score;
            this.next = next;
        }
    }
}
