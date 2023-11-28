using System;
using System.Collections.Generic;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                return 0;

            List<char> delimiters = new List<char> {',', '\n'};

            char firstCharacter = userInput[0];
            if (firstCharacter == ';')
            {
                //delimiters.Add(firstCharacter);
                delimiters.Insert(0, firstCharacter);
            }

            string[] holder = userInput.Split(delimiters.ToArray(), StringSplitOptions.None);

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
    }
}
