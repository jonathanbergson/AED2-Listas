using System;

namespace AED2_Lista03
{
    class List
    {
        private Node head;
        private Node tail;

        public List()
        {
            Score score = new Score("head", -1, "head");
            head = new Node(score, null);
            tail = head;
        }

        public void Prepend(Score score)
        {
            Node node = new Node(score, head.Next);
            head.Next = node;

            if (node.Next == null)
            {
                tail = node;
            }
        }

        public void Add(Score score)
        {
            Node node = new Node(score, null);
            tail.Next = node;
            tail = node;
        }

        public Score Shift()
        {
            Node firstNode = head.Next;
            if (firstNode == null)
            {
                throw new Exception("[Exception] Não existe item para ser deletado!");
            }

            Score deleted = firstNode.Score;
            head.Next = firstNode.Next;

            if (head.Next == null)
            {
                tail = head;
            }

            return deleted;
        }

        public Score Pop()
        {
            if (head == tail)
            {
                throw new Exception("[Exception] Não existe item para ser deletado!");
            }

            Score deleted = tail.Score;

            Node node = head;
            while(node.Next != tail)
            {
                node = node.Next;
            }

            tail = node;
            tail.Next = null;

            return deleted;
        }

        public bool Search(Score score)
        {
            Node node = head.Next;
            bool hasScore = false;
            
            while (node != null)
            {
                if (Score.IsEqual(score, node.Score))
                {
                    Console.WriteLine($"\tNome: {node.Score.Name} - Score: {node.Score.Value} - Data: {node.Score.Date}");
                    hasScore = true;
                    break;
                }

                node = node.Next;
            }

            return hasScore;
        }

        public void Show()
        {
            Node node = head.Next;

            Console.WriteLine("\n[");
            while(node != null)
            {
                Console.WriteLine($"\tNome: {node.Score.Name} - Score: {node.Score.Value} - Data: {node.Score.Date}");
                node = node.Next;
            }
            Console.WriteLine("]\n");
        }

        public static List Concat(List l1, List l2)
        {
            List l3 = new List();

            l3.head.Next = l1.head.Next;
            l3.tail = l1.tail;
            l3.tail.Next = l2.head.Next;
            l3.tail = l2.tail;

            return l3;
        }
    }
}
