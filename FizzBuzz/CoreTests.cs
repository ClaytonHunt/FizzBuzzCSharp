using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    public class CoreTests
    {
        protected IFizzBuzzCommand Fb;

        [TestInitialize]
        public void Initialize()
        {
            Setup();
        }

        protected virtual void Setup() { }

        [TestMethod]
        public void ItOutputs1For1()
        {
            // Act
            var result = Fb.Execute(1);

            // Assert
            Assert.AreEqual("1", result);
        }

        [TestMethod]
        public void It2For2()
        {
            // Act
            var result = Fb.Execute(2);

            // Assert
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void ItOutputsFizzFor3()
        {
            // Act
            var result = Fb.Execute(3);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public void ItOutputsFizzForNumbersDivisibleBy3()
        {
            // Act
            var a = Fb.Execute(6);
            var b = Fb.Execute(9);
            var c = Fb.Execute(12);

            // Assert
            Assert.AreEqual("Fizz", a);
            Assert.AreEqual("Fizz", b);
            Assert.AreEqual("Fizz", c);
        }

        [TestMethod]
        public void ItOutputsBuzzFor5()
        {
            // Act
            var result = Fb.Execute(5);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public void ItOutputsBuzzForNumbersDivisibleBy5()
        {
            // Act
            var a = Fb.Execute(10);
            var b = Fb.Execute(20);
            var c = Fb.Execute(25);

            // Assert
            Assert.AreEqual("Buzz", a);
            Assert.AreEqual("Buzz", b);
            Assert.AreEqual("Buzz", c);
        }

        [TestMethod]
        public void ItOutputsFizzBuzzFor15()
        {
            // Act
            var result = Fb.Execute(15);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public void ItOutputsFizzBuzzForNumbersDivisibleBy3And5()
        {
            // Act
            var a = Fb.Execute(30);
            var b = Fb.Execute(45);
            var c = Fb.Execute(60);

            // Assert
            Assert.AreEqual("FizzBuzz", a);
            Assert.AreEqual("FizzBuzz", b);
            Assert.AreEqual("FizzBuzz", c);
        }
    }
}