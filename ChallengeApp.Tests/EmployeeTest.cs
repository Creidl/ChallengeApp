namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void AverageLetterTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade('C');
            employee1.AddGrade('B');
            employee1.AddGrade('A');
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual('B', statistics.AverageLetter);
        }
        [Test]
        public void MaxRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(10);
            employee1.AddGrade('A');
            employee1.AddGrade(40);
            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void MinRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(100);
            employee1.AddGrade(50);
            employee1.AddGrade('E');
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }
        [Test]
        public void AverageRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade('C');
            employee1.AddGrade('B');
            employee1.AddGrade('A');
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual(80, statistics.Average);
        }
    }
}