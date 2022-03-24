using System;

namespace AED2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Score score;

                List l1 = new List();
                score = new Score("Emerson", 3, "03/10/1988");
                l1.Push(score);
                score = new Score("Jonathan", 85, "09/09/1993");
                l1.Push(score);
                score = new Score("Jonathan", 85, "09/09/1993");
                l1.Push(score);
                score = new Score("Luana", 8, "08/08/1994");
                l1.Push(score);
                l1.Show();

                List l2 = new List();
                score = new Score("Jordan", 29, "29/03/2001");
                l2.Push(score);
                score = new Score("Mairon", 26, "26/09/2002");
                l2.Push(score);
                score = new Score("Lara", 8, "08/02/2002");
                l2.Push(score);
                score = new Score("Jonathan", 85, "09/09/1993");
                l2.Push(score);
                score = new Score("Mairon", 26, "26/09/2002");
                l2.Push(score);
                l2.Show();

                //List listConcat = List.Concat(l1, l2);
                //listConcat.Show();

                //List listIntercalation = List.Intercalation(l1, l2);
                //listIntercalation.Show();

                //List listUnion = List.Union(l1, l2);
                //listUnion.Show();

                //List listIntersection = List.Intersection(l1, l2);
                //listIntersection.Show();

                //List listReverser = l1.Revert();
                //listReverser.Show();

                //List listRemovedOdd = l1.RemoveOdd();
                //listRemovedOdd.Show();

                Score minScore = l1.GetMinimum();
                minScore.Value = 32;
                l1.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
