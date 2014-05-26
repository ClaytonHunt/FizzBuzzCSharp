namespace FizzBuzzTest.ChainOfResponsibility
{
    public class BuzzLink : Link
    {
        private readonly Link _next;

        public BuzzLink(Link next)
        {
            _next = next;
        }

        public override string Print(int value)
        {
            return value%5 == 0 ? "Buzz" : _next.Print(value);
        }
    }
}