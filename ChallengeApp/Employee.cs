namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>(); 
        public Employee(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)

        {
            this.score.Add(number);
        }
    }
}
