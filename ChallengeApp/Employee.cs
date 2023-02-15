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
