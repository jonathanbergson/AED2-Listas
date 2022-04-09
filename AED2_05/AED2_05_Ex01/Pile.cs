using System;

namespace AED2_05_Ex01
{
    class Pile
    {
        private Node _top = null;
        private int _count = 0;

        public int Count => _count;

        public void Add(char character)
        {
            _top = new Node(character, _top);
            _count++;
        }

        public char Remove()
        {
            if (_top == null)
            {
                throw new Exception("[Exception] todos os elementos já foram remodivos.");
            }

            char removed = _top.Character;
            _top = _top.Next;
            return removed;
        }
    }
}
