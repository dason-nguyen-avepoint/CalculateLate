using ClassLibrary1;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var a = new Class1();
            Assert.Pass();
        }
    }
}