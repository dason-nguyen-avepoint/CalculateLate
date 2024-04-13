using CalculateLate;

namespace TestProject2
{
    public class Tests
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
            TimeSpan checkResult = check_in - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void NotRegisterTest2()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime? start_leave;
            DateTime? end_leave;
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void NotRegisterTest3()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime? start_leave;
            DateTime? end_leave;
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void NotRegisterTest4()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime? start_leave;
            DateTime? end_leave;
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void NotRegisterTest5()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime? start_leave;
            DateTime? end_leave;
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave = null, end_leave = null);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest1()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024,01,01,07,0,0);
            DateTime end_leave = new DateTime(2024,01,01,13,0,0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest2()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest3()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest4()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest5()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest6()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest7()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest8()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest9()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest10()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest11()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest12()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest13()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = check_in - end_break;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest14()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest15()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest16()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = check_in - end_break;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest17()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest18()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest19()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = check_in - end_break;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest20()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest21()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 07, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest22()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = check_in - end_break;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest23()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest24()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 08, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest25()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 30, 0);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest26()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 0, 0);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest27()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 45, 0);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest28()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 0, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest29()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest30()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 0, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest31()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 7, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 0, 0);
            TimeSpan checkResult = (start_break - end_leave) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest32()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 30, 0);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest33()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 0, 0);
            TimeSpan checkResult = TimeSpan.Zero;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest34()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 45, 0);
            TimeSpan checkResult = check_in - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest35()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 0, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest36()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest37()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 0, 0);
            TimeSpan checkResult = start_break - end_leave;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest38()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 0, 0);
            TimeSpan checkResult = (start_break - end_leave) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #region 
        // start_shift < start_leave < start_break
        public void RegisterTest39()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 09, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = start_leave - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest40()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = start_leave - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest41()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest42()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = start_leave - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest43()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = start_leave - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest44()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest45()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest46()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest47()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest48()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest49()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest50()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest51()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest52()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest53()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest54()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 30, 0);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest55()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 0, 0);
            TimeSpan checkResult = (start_leave - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest56()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 11, 45, 0);
            TimeSpan checkResult = (start_leave - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest57()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 0, 0);
            TimeSpan checkResult = (start_leave - start_shift) + (start_break - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest58()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 0);
            TimeSpan checkResult = (start_leave - start_shift) + (start_break - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest59()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 0, 0);
            TimeSpan checkResult = (start_leave - start_shift) + (start_break - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest60()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 9, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 11, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 0, 0);
            TimeSpan checkResult = (start_leave - start_shift) + (start_break - end_leave) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #endregion
        #region 
        // start_shift < start_leave = start_break
        public void RegisterTest61()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest62()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest63()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest64()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest65()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest66()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest67()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest68()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest69()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest70()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest71()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest72()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest73()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest74()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest75()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #endregion
        #region 
        // start_shift < start_break < start_leave < end_break
        public void RegisterTest76()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest77()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest78()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest79()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest80()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest81()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest82()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest83()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest84()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 12, 30, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 00, 00);
            TimeSpan checkResult = (start_break - start_shift);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #endregion
        #region 
        // start_shift < start_break < start_leave = end_break
        public void RegisterTest85()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest86()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 12, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest87()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest88()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 00, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest89()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 00);
            TimeSpan checkResult = start_break - start_shift;
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest90()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 08, 00, 00);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 00, 00);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 00, 00);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 00, 00);
            DateTime start_leave = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 00);
            TimeSpan checkResult = (start_break - start_shift) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #endregion
        #region 
        // start_shift < start_break <  end_break < start_leave 
        [Test]
        public void RegisterTest91()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 0, 0);
            TimeSpan checkResult = (start_break - start_shift) + (start_leave - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest92()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 13, 30, 0);
            TimeSpan checkResult = (start_break - start_shift) + (start_leave - end_break);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        [Test]
        public void RegisterTest93()
        {
            DateTime start_shift = new DateTime(2024, 01, 01, 8, 0, 0);
            DateTime end_shift = new DateTime(2024, 01, 01, 17, 0, 0);
            DateTime start_break = new DateTime(2024, 01, 01, 12, 0, 0);
            DateTime end_break = new DateTime(2024, 01, 01, 13, 0, 0);
            DateTime start_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime end_leave = new DateTime(2024, 01, 01, 14, 0, 0);
            DateTime check_in = new DateTime(2024, 01, 01, 14, 30, 0);
            TimeSpan checkResult = (start_break - start_shift) + (start_leave - end_break) + (check_in - end_leave);
            TimeSpan result = _calculate.CalculateLate(start_shift, start_break, end_break, check_in, start_leave, end_leave);
            Assert.That(result, Is.EqualTo(checkResult));
        }
        #endregion
    }
}