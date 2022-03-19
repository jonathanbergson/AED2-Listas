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

        public void Push(Score score)
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

            Node node = l1.head.Next;
            while (node != null)
            {
                Score score = new Score(node.Score.Name, node.Score.Value, node.Score.Date);
                l3.Push(score);
                node = node.Next;
            }

            node = l2.head.Next;
            while (node != null)
            {
                Score score = new Score(node.Score.Name, node.Score.Value, node.Score.Date);
                l3.Push(score);
                node = node.Next;
            }

            return l3;
        }

        public static List Intercalation(List l1, List l2)
        {
            List l3 = new List();

            Node n1 = l1.head.Next;
            Node n2 = l2.head.Next;
            while (n1 != null || n2 != null)
            {
                Score s1 = new Score(n1.Score.Name, n1.Score.Value, n1.Score.Date);
                Score s2 = new Score(n2.Score.Name, n2.Score.Value, n2.Score.Date);

                if (n1.Score.Value < n2.Score.Value)
                {
                    l3.Push(s1);
                    l3.Push(s2);
                } else
                {
                    l3.Push(s2);
                    l3.Push(s1);
                }

                n1 = n1.Next;
                n2 = n2.Next;
            }

            return l3;
        }
    }
}
