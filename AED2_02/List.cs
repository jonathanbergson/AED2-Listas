using System;
using System.IO;

namespace AED2_02
{
    class List
    {
        int count = 0;
        Score[] list;

        public List(int count)
        {
            list = new Score[count];
        }

        public void Prepend(Score score)
        {
            if (count == list.Length)
            {
                throw new Exception($"[Exception] Deu ruim, a lista já está cheia!");
            }
            else
            {
                for (int i = count; i > 0; i--)
                {
                    list[i] = list[i - 1];
                }

                list[0] = score;
                count++;
            }
        }

        public int Add(Score score)
        {
            if (count == list.Length)
            {
                throw new Exception($"[Exception] Deu ruim, a lista já está cheia!");
            }
            else
            {
                int index = count;
                list[index] = score;
                count++;

                return index;
            }
        }

        public void Add(Score score, int index)
        {
            if (count == list.Length)
            {
                throw new Exception($"[Exception] Deu ruim, a lista já está cheia!");
            }
            else if (index < 0 || index >= list.Length)
            {
                throw new Exception($"[Exception] Deu ruim, posição inválida!");
            }
            else
            {
                for (int i = count; i > index; i--)
                {
                    list[i] = list[i - 1];
                }
                list[index] = score;
                count++;
            }
        }

        public Score Shift()
        {
            if (count == 0)
            {
                throw new Exception($"[Exception] Deu ruim, a lista já está vazia!");
            }
            else
            {
                count--;
                Score score = list[0];
                for (int i = 0; i < count; i++)
                {
                    list[i] = list[i + 1];
                }
                return score;
            }
        }

        public Score Pop()
        {
            if (count == 0)
            {
                throw new Exception($"[Exception] Deu ruim, a lista já está vazia!");
            }
            else
            {
                Score score = list[count - 1];
                count--;
                return score;
            }
        }

        public Score Delete(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new Exception($"[Exception] Deu ruim, posição inválida!");
            }
            else
            {
                count--;
                Score score = list[index];
                for (int i = index; i < count; i++)
                {
                    list[i] = list[i + 1];
                }
                return score;
            }
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"\tNome* \t\t\tPontuação* \tData*");
            for (int i = 0; i < count; i++)
            {
                Score score = list[i];
                Console.Write($"\t{score.Name}");
                Console.Write($"\t{score.Count}");
                Console.Write($"\t\t{score.Date}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int Search(Score score)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                Score current = list[i];
                if (score.Name == current.Name && score.Count == current.Count && score.Date == current.Date)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public bool IsOrdered()
        {
            for (int i = 1; i < count; i++)
            {
                Score current = list[i];
                Score previous = list[i - 1];
                if (previous.Count >= current.Count)
                {
                    return false;
                }
            }
            return true;
        }

        public static List ReadFile(string path)
        {
            string line;
            bool isFirstLine = true;
            List list = new List(0);

            using (StreamReader stream = new StreamReader(path))
            {
                while ((line = stream.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        int count = Int32.Parse(line);
                        list = new List(count);
                    }
                    else
                    {
                        string[] data = line.Split(';');

                        string name = data[0];
                        int count = Int32.Parse(data[1]);
                        string date = data[2];

                        Score score = new Score(name, count, date);
                        list.Add(score);
                    }
                }
            }

            return list;
        }

        public void WriteFile(string path)
        {
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.WriteLine($"{count}");

                for (int i = 0; i < count; i++)
                {
                    Score score = list[i];
                    stream.WriteLine($"{score.Name};{score.Count};{score.Date}");
                }
            }
        }
    }
}
