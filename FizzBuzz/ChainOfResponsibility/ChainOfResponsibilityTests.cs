using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest.ChainOfResponsibility
{
    [TestClass]
    public class ChainOfResponsibilityTests : CoreTests
    {
        protected override void Setup()
        {
            var numberLink = new NumberLink();
            var buzzLink = new BuzzLink(numberLink);
            var fizzLink = new FizzLink(buzzLink);
            var fizzBuzzLink = new FizzBuzzLink(fizzLink);

            Fb = new ChainOfResponsibilityFizzBuzz(fizzBuzzLink);
        }
    }
}
