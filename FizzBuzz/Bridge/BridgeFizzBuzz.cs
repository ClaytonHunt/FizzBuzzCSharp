using System.Globalization;

namespace FizzBuzzTest.Bridge
{
    public class BridgeFizzBuzz : IFizzBuzzCommand
    {
        private readonly IOutputBridge _bridge;

        private class NumberBridge : IOutputBridge
        {
            public string Output(int value)
            {
                return value.ToString(CultureInfo.InvariantCulture);
            }
        }

        public BridgeFizzBuzz()
        {
            _bridge = new NumberBridge();
        }

        public BridgeFizzBuzz(IOutputBridge bridge)
        {
            _bridge = bridge;
        }

        public string Execute(int value)
        {
            return _bridge.Output(value);
        }
    }

    public interface IOutputBridge
    {
        string Output(int value);
    }
}