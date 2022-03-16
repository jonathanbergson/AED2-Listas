using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED2_Lista03
{
    class Score
    {
        int value;
        string name;
        string date;

        public int Value
        {
            get { return value; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Date
        {
            get { return date; }
        }

        public Score(string name, int value, string date)
        {
            this.value = value;
            this.name = name;
            this.date = date;
        }
    }
}
