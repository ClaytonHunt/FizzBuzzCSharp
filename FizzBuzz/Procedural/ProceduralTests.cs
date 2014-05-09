using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest.Procedural
{
    [TestClass]
    public class ProceduralTests : CoreTests
    {
        protected override void Setup()
        {
            Fb = new ProceduralFizzBuzz();
        }
    }
}
