using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest.Bridge
{
    [TestClass]
    public class BridgeTests : CoreTests
    {
        protected override void Setup()
        {
            Fb = new BridgeFizzBuzz(new FizzBuzzBridge());
        }

        private static BridgeFizzBuzz NumberSetup()
        {
            return new BridgeFizzBuzz();
        }

        private static BridgeFizzBuzz BarBazSetup()
        {
            return new BridgeFizzBuzz(new BarBazBridge());
        }

        [TestMethod]
        public void GivenNumberBridgeAndNumberItPrintsStringNumber()
        {
            CheckNumber(1, "1");
            CheckNumber(2, "2");
            CheckNumber(3, "3");
            CheckNumber(4, "4");
            CheckNumber(5, "5");
            CheckNumber(6, "6");
            CheckNumber(7, "7");
            CheckNumber(8, "8");
            CheckNumber(9, "9");
            CheckNumber(10, "10");
        }

        [TestMethod]
        public void GivenBarBazBridgeAndNumberItPrintsStringBarBazOrNumber()
        {
            CheckBarBaz(1, "1");
            CheckBarBaz(2, "2");
            CheckBarBaz(3, "3");
            CheckBarBaz(4, "Bar");
            CheckBarBaz(5, "5");
            CheckBarBaz(6, "Baz");
            CheckBarBaz(7, "7");
            CheckBarBaz(8, "Bar");
            CheckBarBaz(9, "9");
            CheckBarBaz(10, "10");
            CheckBarBaz(11, "11");
            CheckBarBaz(12, "BarBaz");
        }

        private void CheckBarBaz(int value, string expected)
        {
            var fb = BarBazSetup();
            CheckBridge(fb, value, expected);
        }

        private void CheckNumber(int value, string expected)
        {
            var fb = NumberSetup();
            CheckBridge(fb, value, expected);
        }

        private static void CheckBridge(IFizzBuzzCommand fb, int value, string expected)
        {
            // Act
            var result = fb.Execute(value);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
