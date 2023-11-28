using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return 0;

            var holder = ExtractNumbers(userInput);

            int result = 0;
            List<int> negatives = new List<int>();

            foreach (string number in holder)
            {
                int parsedNumber = int.Parse(number);

                if (parsedNumber < 0)
                {
                    negatives.Add(parsedNumber);
                }

                result += parsedNumber;
            }

            if (negatives.Count > 0)
            {
                string negativeNumbers = string.Join(", ", negatives);
                throw new ArgumentException($"Negatives not allowed: {negativeNumbers}");
            }

            return result;
        }

        static List<string> ExtractNumbers(string input)
        {
            List<string> numbers = new List<string>();

            string pattern = @"-?\d+\.?\d*";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                numbers.Add(match.Value);
            }

            return numbers;
        }
    }
}
