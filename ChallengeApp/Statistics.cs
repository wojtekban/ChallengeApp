﻿namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public float Count { get; private set; }

        public float Average 
        { 
                get
                {
                    return this.Sum / this.Count;
                }
            
        }

        public char AverageLetter 
        { 
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;  
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}
