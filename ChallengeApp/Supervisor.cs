namespace ChallengeApp
{
    internal class Supervisor : Person,IEmployee
    {
        private List<float> grade = new List<float>();

        public Supervisor(string name = "Super Zombie", string surname = "X", char sex = 'Z')
        : base(name, surname, sex)
        {

        }

        public void AddGrade(float grade)
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

        public void AddGrade(double grade)
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
        public void AddGrade(long grade)
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

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    AddGrade(15);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        AddGrade(result);
                        break;
                    }
                    else
                    {
                        throw new Exception("  Wrong Letter");
                    }
            }
        }

        public void AddGrade(char grade)
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

        public Statistics GetStatistics()
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
