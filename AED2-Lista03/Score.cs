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

        public static bool IsEqual(Score s1, Score s2)
        {
            if (s1.Name == s2.Name && s1.Value == s2.Value && s1.Date == s2.Date)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
