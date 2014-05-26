namespace FizzBuzzTest.ChainOfResponsibility
{
    public class NumberLink : Link
    {
        public override string Print(int value)
        {
            return value.ToString();
        }
    }
}