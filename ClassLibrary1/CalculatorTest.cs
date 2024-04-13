using CalculateLate;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculate _calculate;
        [SetUp]
        public void Setup()
        {
            _calculate = new Calculate();
        }
        [Test]
        public void NotRegisterTest1()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime? start_leave;
            DateTime? end_leave;
            DateTime check_in = new DateTime(2024, 01, 01, 09, 00, 00);
            TimeSpan checkResult = new TimeSpan(1, 0, 0);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            
        }
    }
}
