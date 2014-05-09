namespace FizzBuzzTest.Procedural
{
    public class ProceduralFizzBuzz : IFizzBuzzCommand
    {
        public string Execute(int value)
        {
            if (IsDivisibleBy3And5(value))
                return Fizz() + Buzz();

            if (IsDivisibleBy3(value))
                return Fizz();

            if(IsDivisibleBy5(value))
                return Buzz();

            return value.ToString();
        }

        private static string Buzz()
        {
            return "Buzz";
        }

        private static string Fizz()
        {
            return "Fizz";
        }

        private static bool IsDivisibleBy3And5(int value)
        {
            return IsDivisibleBy3(value) && IsDivisibleBy5(value);
        }

        private static bool IsDivisibleBy5(int value)
        {
            return value % 5 == 0;
        }

        private static bool IsDivisibleBy3(int value)
        {
            return value % 3 == 0;
        }
    }
}