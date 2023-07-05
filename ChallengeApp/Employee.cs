namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private List<float> grade = new List<float>();
        
        public Employee(string firstName = "Zombie", string lastName = "X")
        {
            Name = firstName;
            Surname = lastName;
        }
        public void AddGrade(float grade)
        {
            this.grade.Add(grade);
        }
        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            stats.Average = 0;

            foreach (var grade in this.grade)
            {
                stats.Average += grade;
                stats.Max = Math.Max(grade,stats.Max);
                stats.Min = Math.Min(grade,stats.Min);
            }
            stats.Average /= this.grade.Count;
            stats.Score = grade.Sum();
            return stats;
        }
    }
}