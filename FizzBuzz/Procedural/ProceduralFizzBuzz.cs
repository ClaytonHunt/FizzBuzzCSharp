using System.Globalization;

namespace FizzBuzzTest.Procedural
{
    public class ProceduralFizzBuzz : IFizzBuzzCommand
    {
        public string Execute(int value)
        {
            if (CanFizz(value) && CanBuzz(value))
                return "FizzBuzz";

            if (CanFizz(value))
                return "Fizz";

            if(CanBuzz(value))
                return "Buzz";

            return value.ToString(CultureInfo.InvariantCulture);
        }

        private static bool CanFizz(int value)
        {
            return value % 3 == 0;
        }

        private static bool CanBuzz(int value)
        {
            return value % 5 == 0;
        }
    }
}