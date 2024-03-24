using Lab1;

namespace Lab1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTask_1()
        {
            double actual = Lab1Program.findAvgModule(5, 6);
            double expected = 5.5;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestTask_2()
        {
            bool actual = Lab1Program.isEndOnSeven(7);
            bool expected = true;
            Assert.AreEqual(actual, expected);

            actual = Lab1Program.isEndOnSeven(3);
            expected = false;
            Assert.AreEqual(actual, expected);
        }
    }
}