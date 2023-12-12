namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        protected int counter;
        public Person(string name, string surName, int age)
        {
            this.Name = name;
            this.SurName = surName;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string SurName { get; private set; }

        public int Age { get; private set; }
    }
}
