namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>(); 
        public Employee(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string SurName { get; private set; }

        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
 
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Proszę wybrać punkty z przedziału od 0 do 100");
            }
        }
        public void AddGrade(string grade)
        {
            {
                if(float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else 
                {
                    Console.WriteLine("string in not float");
                }
            }
        }
        public Statistics GetStatisticsForEach()
        {
            var statistics = new Statistics();

            statistics.Average= 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average = this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i<this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];

            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do 
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            } 

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public void AddGrade(long grade)
            {
            float result = grade;
            this.AddGrade(result);
            }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(decimal grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public  Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max= float.MinValue;


            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average+= grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
             
            return statistics;
        }
    }
}
