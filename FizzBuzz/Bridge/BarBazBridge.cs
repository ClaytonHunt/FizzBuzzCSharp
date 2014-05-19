using System.Globalization;

namespace FizzBuzzTest.Bridge
{
    internal class BarBazBridge : IOutputBridge
    {
        public string Output(int value)
        {
            if (CanBar(value) && CanBaz(value))
                return "BarBaz";
            
            if (CanBar(value))
                return "Bar";

            if (CanBaz(value))
                return "Baz";

            return value.ToString(CultureInfo.InvariantCulture);
        }

        private static bool CanBaz(int value)
        {
            return value%6 == 0;
        }

        private static bool CanBar(int value)
        {
            return value%4 == 0;
        }
    }
}