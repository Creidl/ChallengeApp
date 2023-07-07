using System.Diagnostics;

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
            if (grade > 0 && grade <= 100)
            {
                this.grade.Add(grade);
            }
            else
            {
                Console.WriteLine($"  Wartość: {grade} jest spoza zakresu ocen!");
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
                Console.WriteLine("  Przekroczenie zasięgu FLOAT! ==> Wartość spoza zakresu ocen!");
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
                Console.WriteLine("  Przekroczenie zasięgu FLOAT! ==> Wartość spoza zakresu ocen!");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine($"  Wpisana ocena: {grade} nie jest liczbą!");
            }
        }

        public void AddGrade(char grade)
        {
           switch(grade)
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
                    Console.WriteLine("Wrong letter");
                    break;
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
                stats.Max = Math.Max(grade,stats.Max);
                stats.Min = Math.Min(grade,stats.Min);
            }
            stats.Average /= this.grade.Count;

            switch(stats.Average)
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