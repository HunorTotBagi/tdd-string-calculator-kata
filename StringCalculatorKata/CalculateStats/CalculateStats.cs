namespace src.KATA
{
    public class CalculateStats
    {
        private int[] _sequence;

        public int Maximum { get; }
        public int Minimum { get; }
        public int NumberOfElements { get; }
        public double Average { get; }

        public CalculateStats(int[] sequence)
        {
            _sequence = sequence;

            Maximum = _sequence.Max();
            Minimum = _sequence.Min();
            NumberOfElements = _sequence.Count();
            Average = _sequence.Average();
        }
    }
}