namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(char grade);

        void AddGrade(string grade);
    }
}