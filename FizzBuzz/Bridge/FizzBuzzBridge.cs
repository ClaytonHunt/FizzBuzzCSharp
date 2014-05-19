namespace FizzBuzzTest.Bridge
{
    public class FizzBuzzBridge : IOutputBridge
    {
        public string Output(int value)
        {
            if (CanFizz(value) && CanBuzz(value))
                return "FizzBuzz";

            if (CanFizz(value))
                return "Fizz";

            if (CanBuzz(value))
                return "Buzz";

            return value.ToString();
        }

        private static bool CanFizz(int value)
        {
            return value%3 == 0;
        }

        private static bool CanBuzz(int value)
        {
            return value%5 == 0;
        }
    }
}