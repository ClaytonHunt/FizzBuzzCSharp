namespace FizzBuzzTest.ChainOfResponsibility
{
    public class ChainOfResponsibilityFizzBuzz : IFizzBuzzCommand
    {
        private readonly Link _link;

        public ChainOfResponsibilityFizzBuzz(Link link)
        {
            _link = link;
        }

        public string Execute(int value)
        {
            return _link.Print(value);
        }
    }
}