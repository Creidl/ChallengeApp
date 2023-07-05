namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ScoreSumTest()
        {
            Employee employee1 = new Employee();
            employee1.score.AddScore(1);
            employee1.score.AddScore(2);
            employee1.score.AddScore(3);

            Assert.AreEqual(6, employee1.score.GetScore());
        }
        [Test]
        public void MaxRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.score.AddScore(1);
            employee1.score.AddScore(-2);
            employee1.score.AddScore(-9);
            Assert.AreEqual(1, employee1.score.Max);
        }
        [Test]
        public void MinRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.score.AddScore(10);
            employee1.score.AddScore(-2);
            employee1.score.AddScore(-8);
            Assert.That(employee1.score.Min, Is.EqualTo(-8));
        }
        [Test]
        public void AverageRatingTest()
        {
            Employee employee1 = new Employee();
            employee1.score.AddScore(10);
            employee1.score.AddScore(-2);
            employee1.score.AddScore(-8);
            Assert.That(employee1.score.Average, Is.EqualTo(0));
        }
    }
}