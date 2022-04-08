using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2_04
{
    class Plate
    {
        private int _code;
        private string _name;
        private float _price;
        private bool _enable = true;

        public Plate(int code, string name, float price)
        {
            _code = code;
            _name = name;
            _price = price;
        }
    }
}
