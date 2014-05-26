namespace FizzBuzzTest.ChainOfResponsibility
{
    public class FizzLink : Link
    {
        private readonly Link _next;

        public FizzLink(Link next)
        {
            _next = next;
        }

        public override string Print(int value)
        {
            return value % 3 == 0 ? "Fizz" : _next.Print(value);
        }
    }
}