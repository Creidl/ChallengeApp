using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        public event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(char grade);

        void AddGrade(string grade);
    }
}