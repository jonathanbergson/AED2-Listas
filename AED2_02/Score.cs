namespace AED2_02
{
    class Score
    {
        int count;
        string name;
        string date;

        public int Count
        {
            get { return count; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Date
        {
            get { return date; }
        }

        public Score(string name, int count, string date)
        {
            this.count = count;
            this.name = "";
            this.date = date;

            int maxCharacter = 16;
            for (int i = 0; i < maxCharacter; i++)
            {
                if (name.Length > i)
                {
                    this.name += name[i];
                }
                else
                {
                    this.name += " ";
                }
            }
        }
    }
}
