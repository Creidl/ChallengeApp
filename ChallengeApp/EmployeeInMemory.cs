namespace ChallengeApp
{
    public class EmployeeInMemory: EmployeeBase
    {
        private List<float> grade = new List<float>();

        public EmployeeInMemory (string name, string surname): base(name, surname) 
        { 

        }

        public override void AddGrade(float grade)
        {
            if (grade > 0 && grade <= 100)
            {
                this.grade.Add(grade);
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
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;
            stats.Average = 0;

            foreach (var grade in this.grade)
            {
                stats.Average += grade;
                stats.Max = Math.Max(grade, stats.Max);
                stats.Min = Math.Min(grade, stats.Min);
            }
            stats.Average /= this.grade.Count;

            switch (stats.Average)
            {
                case var a when a > 80:
                    stats.AverageLetter = 'A';
                    break;
                case var a when a > 60:
                    stats.AverageLetter = 'B';
                    break;
                case var a when a > 40:
                    stats.AverageLetter = 'C';
                    break;
                case var a when a > 20:
                    stats.AverageLetter = 'D';
                    break;
                default:
                    stats.AverageLetter = 'E';
                    break;
            }
            return stats;
        }
    }
}
