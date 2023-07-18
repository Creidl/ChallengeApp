namespace ChallengeApp
{
    public class EmployeeInMemory: EmployeeBase
    {
        private List<float> grade = new List<float>();
        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory (string name, string surname): base(name, surname) 
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                this.grade.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"  Wartość: {grade} jest spoza zakresu ocen!");
            }
        }

        public override void AddGrade(double grade)
        {
            if (float.MaxValue >= grade && float.MinValue <= grade)
            {
                AddGrade((float)grade);
            }
            else
            {
                throw new Exception("  Przekroczenie zasięgu FLOAT! ==> Wartość spoza zakresu ocen!");
            }
        }

        public override void AddGrade(long grade)
        {
            if (float.MaxValue >= grade || float.MinValue <= grade)
            {
                AddGrade((float)grade);
            }
            else
            {
                throw new Exception("  Przekroczenie zasięgu FLOAT! ==> Wartość spoza zakresu ocen!");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                throw new Exception($"  wpisana ocena: {grade} nie jest liczbą!");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    AddGrade(100);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(40);
                    break;
                case 'E':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override Statistics GetStatistics()
        {
            Statistics stats = new Statistics();
            
            foreach (var grade in this.grade)
            {
                stats.AddGrade(grade);
            }
            
            return stats;
        }
    }
}
