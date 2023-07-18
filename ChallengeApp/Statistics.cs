namespace ChallengeApp
{
    public class Statistics
    {
        public float Max {get; private set;}

        public float Min { get; private set;}

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average { get
            {
                return Sum / Count;
            }
        }

        public char AverageLetter { get
            {
                switch (Average)
                {
                    case var a when a > 80:
                        return 'A';
                    case var a when a > 60:
                        return 'B';
                    case var a when a > 40:
                        return 'C';
                    case var a when a > 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            Sum = 0;
            Count = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            Count++;
            Sum += grade;
            Max = Math.Max(Max, grade);
            Min = Math.Min(Min, grade);
        }
    }
}