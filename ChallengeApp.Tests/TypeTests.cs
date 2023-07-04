namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestObjects()
        {
            Employee employee1 = new Employee("John");
            Employee employee2 = new Employee("John");

            Assert.AreNotEqual(employee1, employee2);
        }
        [Test]
        public void TestInt()
        {
            int a= 11, b = 11;

            Assert.AreEqual(a, b);
        }
        [Test]
        public void TestFloat()
        {
            float a = 11.99f, b = 11.99f;

            Assert.AreEqual(a, b);
        }
        [Test]
        public void TestString()
        {
            string a = "11", b = "11";

            Assert.AreEqual(a, b);
        }
    }
}