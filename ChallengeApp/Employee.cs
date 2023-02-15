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
            this.grades.Add(grade);
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
                //

            return statistics;
        }
    }
}
