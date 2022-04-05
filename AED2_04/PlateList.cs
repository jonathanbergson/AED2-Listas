using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2_04
{
    class PlateList
    {
        private Plate _head;
        private Plate _tail;

        public PlateList()
        {
            Plate head = new Plate(0, "head", 0f);
            _head = head;
            _tail = head;
        }
    }
}
