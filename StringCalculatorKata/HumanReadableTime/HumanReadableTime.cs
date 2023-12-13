// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
// - HH = hours, padded to 2 digits, range: 00 – 99
// - MM = minutes, padded to 2 digits, range: 00 – 59
// - SS = seconds, padded to 2 digits, range: 00 – 59
// The maximum time never exceeds 359_999 (99:59:59).

namespace StringCalculatorKata.HumanReadableTime
{
    public class HumanReadableTime
    {
        public static string Convert(int input)
        {
            if (input > 359_999 || input < 0) 
                return "00:00:00";

            int hours = input / 3600;
            int minutes = input % 3600 / 60;
            int seconds = input % 60;

            return ConvertToDoubleDigit(hours) + ":" +
                   ConvertToDoubleDigit(minutes) + ":" +
                   ConvertToDoubleDigit(seconds);
        }

        private static string ConvertToDoubleDigit(int input)
        {
            return input < 10 ? "0" + input : "" + input;
        }
    }
}