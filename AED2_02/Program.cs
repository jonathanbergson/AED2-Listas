using System;

namespace AED2_02
{
    class Program
    {
        static string path = ".\\data.txt";

        static void Main(string[] args)
        {
            ReadFile();
            //WriteFile();
            //CallAllListMethods();
        }

        static void ReadFile()
        {
            try
            {
                List list = List.ReadFile(path);
                list.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void WriteFile()
        {
            try
            {
                Score score;
                List list = new List(5);

                score = new Score("Jonathan Bergson", 85, "09/09/1993");
                list.Add(score);
                score = new Score("Luana Stephanie", 8, "08/08/1994");
                list.Add(score);
                score = new Score("Jordan Matheus", 29, "29/03/2001");
                list.Add(score);

                list.WriteFile(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CallAllListMethods()
        {
            try
            {
                Score score;
                List list = new List(15);

                score = new Score("Jonathan Bergson", 85, "09/09/1993");
                list.Add(score);
                score = new Score("Luana Stephanie", 8, "08/08/1994");
                list.Add(score);
                score = new Score("Jordan Matheus", 29, "29/03/2001");
                list.Add(score);
                list.Show();

                score = new Score("Lara Cristina", 82, "08/02/2002");
                int index = list.Search(score);
                Console.WriteLine($"\tA Busca por \"{score.Name}\" está no index: {index}");

                score = new Score("Mairon Bergson", 5, "26/09/2002");
                list.Prepend(score);
                score = new Score("Heirtor Bergson", 12, "10/02/2007");
                list.Add(score);
                score = new Score("Adair Mateus", 9, "09/12/1963");
                list.Prepend(score);
                list.Show();

                score = list.Shift();
                Console.WriteLine($"\tRemovido Inicio: {score.Name}");
                score = list.Pop();
                Console.WriteLine($"\tRemovido Fim: {score.Name}");
                list.Show();

                score = new Score("Cristina Mara", 7, "20/10/1961");
                list.Add(score, 1);
                list.Show();

                list.Delete(2);
                list.Show();

                Console.WriteLine($"\tEstá tudo em ordem? {list.IsOrdered()}");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
