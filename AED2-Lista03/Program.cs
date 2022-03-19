using System;

namespace AED2_Lista03
{
    class Program
    {
        static void Main(string[] args)
        {
            Score score;
            List list1 = new List();

            score = new Score("Luana", 8, "08/08/1994");
            list1.Add(score);
            score = new Score("Jonathan", 85, "09/09/1993");
            list1.Add(score);
            list1.Show();

            List list2 = new List();
            score = new Score("Jordan", 29, "29/03/2001");
            list2.Prepend(score);
            list2.Add(score);
            list2.Show();

            List list3 = List.Concat(list1, list2);
            list3.Show();


            score = new Score("Lara", 8, "08/02/2002");
            list1.Add(score);
            list3.Show();
        }
    }
}
