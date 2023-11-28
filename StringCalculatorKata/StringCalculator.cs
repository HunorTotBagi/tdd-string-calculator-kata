namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
                    return 0;

            string[] holder = userInput.Split(',');

            int result = 0;
            foreach (string number in holder)
            {
                result += int.Parse(number);
            }

            return result;
        }
    }
}
