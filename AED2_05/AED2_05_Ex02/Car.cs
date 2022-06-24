namespace AED2_05_Ex02
{
    public class Car
    {
        private int _moved;
        public int Moved => _moved;
        public string Plate { get; }

        public Car(string plate)
        {
            Plate = plate;
            _moved = 0;
        }

        public int Move()
        {
            _moved++;
            return Moved;
        }
    }
}
