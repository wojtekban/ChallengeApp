namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public  event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public Supervisor(string name, string surName, int age)
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

            if (grade >= 1 && grade <= 6)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Proszę wybrać punkty z przedziału od 1 do 6");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            { 
                switch (grade)
                {
                    case "6":
                        this.grades.Add(100);
                        break;
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "4":
                        this.grades.Add(60);
                        break;
                    case "3":
                        this.grades.Add(40);
                        break;
                    case "-3":
                    case "3-":
                        this.grades.Add(35);
                        break;
                    case "2+":
                    case "+2":
                        this.grades.Add(25);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    case "1":
                        this.grades.Add(0);
                        break;
                    default:
                        throw new Exception("Wrong letter");
                }
        }   

        }
        public void AddGrade(long grade)
            {
                float result = grade;
                this.AddGrade(result);
            }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
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

        public Statistics GetStatistics()
        {
             var statistics = new Statistics();
             statistics.Average = 0;
             statistics.Min = float.MaxValue;
             statistics.Max = float.MinValue;


             foreach (var grade in this.grades)
             {
                 if (grade >= 0)
                 {
                      statistics.Max = Math.Max(statistics.Max, grade);
                      statistics.Min = Math.Min(statistics.Min, grade);
                      statistics.Average += grade;
                 }
             }

             statistics.Average = statistics.Average / this.grades.Count;

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }

                return statistics;
        }

    }  
}
