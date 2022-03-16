using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2_Lista03
{
    class List
    {
        private Node head;
        private Node tail;

        public List()
        {
            Score score = new Score("head", 0, "head");
            head = new Node(score, null);
            tail = head;
        }

        public void Prepend(Score score)
        {

        }

        public void Add(Score score)
        {
            Node node = new Node(score, null);
            tail.Next = node;
            tail = node;
        }

        public Score Shift()
        {
            return new Score("temp", 1, "temp");
        }

        public Score Pop()
        {
            return new Score("temp", 1, "temp");
        }

        public bool Search(Score score)
        {
            return false;
        }

        public void Show()
        {

        }
    }
}
