namespace StringCalculatorKata.StringCalcuator.StringCalculator
{
    public class StringCalculatorCode
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return 0;

            List<char> delimiters = GetDelimiters(userInput);

            string[] numberStrings = GetNumberStrings(userInput, delimiters);

            int result = 0;
            List<int> allNegativeNumbers = new List<int>();

            foreach (string number in numberStrings)
            {
                int parsedNumber = int.Parse(number);

                if (parsedNumber < 0)
                    allNegativeNumbers.Add(parsedNumber);

                result += parsedNumber;
            }

            if (allNegativeNumbers.Count > 0)
            {
                string negativeNumbers = string.Join(", ", allNegativeNumbers);
                throw new ArgumentException($"Negatives not allowed: {negativeNumbers}");
            }

            return result;
        }

        public List<char> GetDelimiters(string numbers)
        {
            char firstCharacter = 'a';
            List<char> delimiters = new List<char> { ',', '\n' };
            for (int i = 0; i < numbers.Length; i++)
            {
                firstCharacter = numbers[i];

                if (!char.IsDigit(firstCharacter) && firstCharacter != '-')
                {
                    delimiters.Add(firstCharacter);
                }

            }
            return delimiters;
        }

        private string[] GetNumberStrings(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
