namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return 0;

            List<char> delimiters = GetDelimiters(userInput);

            string[] numberStrings = GetNumberStrings(userInput, delimiters);

            int result = 0;
            List<int> negatives = new List<int>();

            foreach (string number in numberStrings)
            {
                // consider not calculating the result
                int parsedNumber = int.Parse(number);

                if (parsedNumber < 0)
                    negatives.Add(parsedNumber);

                result += parsedNumber;
            }

            if (negatives.Count > 0)
            {
                string negativeNumbers = string.Join(", ", negatives);
                throw new ArgumentException($"Negatives not allowed: {negativeNumbers}");
            }

            return result;
        }

        public List<char> GetDelimiters(string numbers)
        {
            List<char> delimiters = new List<char> { ',', '\n' };
            char firstCharacter = numbers[0];

            if (!char.IsDigit(firstCharacter))
                delimiters.Add(firstCharacter);

            return delimiters;
        }

        private string[] GetNumberStrings(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
