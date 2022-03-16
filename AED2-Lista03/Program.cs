using System;

namespace AED2_Lista03
{
    class Program
    {
        static void Main(string[] args)
        {
            Score score;
            List list = new List();

            score = new Score("Jonathan", 85, "09/09/1993");
            list.Add(score);
        }
    }
}
