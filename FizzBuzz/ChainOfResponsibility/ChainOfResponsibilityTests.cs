using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest.ChainOfResponsibility
{
    [TestClass]
    public class ChainOfResponsibilityTests : CoreTests
    {
        protected override void Setup()
        {
            Fb = new ChainOfResponsibilityFizzBuzz();
        }
    }

    public class ChainOfResponsibilityFizzBuzz : IFizzBuzzCommand
    {
        public ChainOfResponsibilityFizzBuzz()
        {
            
        }

        public string Execute(int value)
        {
            return null;
        }
    }
}
