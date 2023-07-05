namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ScoreSumTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(1);
            employee1.AddGrade(2);
            employee1.AddGrade(3);
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual(6, statistics.Score);
        }
        [Test]
        public void MaxRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(1);
            employee1.AddGrade(-2);
            employee1.AddGrade(-9);
            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(1, statistics.Max);
        }
        [Test]
        public void MinRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(10);
            employee1.AddGrade(-2);
            employee1.AddGrade(-8);
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual(-8, statistics.Min);
        }
        [Test]
        public void AverageRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.AddGrade(10);
            employee1.AddGrade(-2);
            employee1.AddGrade(-8);
            Statistics statistics = employee1.GetStatistics();

            Assert.AreEqual(0, statistics.Average);
        }
    }
}