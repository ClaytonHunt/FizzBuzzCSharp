namespace FizzBuzzTest.ChainOfResponsibility
{
    public class FizzBuzzLink : Link
    {
        private readonly Link _next;

        public FizzBuzzLink(Link next)
        {
            _next = next;
        }

        public override string Print(int value)
        {
            return value % 3 == 0 && value % 5 == 0 ? "FizzBuzz" : _next.Print(value);
        }
    }
}