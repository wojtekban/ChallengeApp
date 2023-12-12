namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestAverage()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski", 30);
            employee.AddGrade(100);
            employee.AddGrade('B');
            employee.AddGrade(60);
            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade(0);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Average, 50);
        }
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestMax()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski",30);
            employee.AddGrade('A');
            employee.AddGrade(80);
            employee.AddGrade(60);
            employee.AddGrade(40);
            employee.AddGrade(20);
            employee.AddGrade(0);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Max,100);
        }
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestMin()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski", 30);
            employee.AddGrade(100);
            employee.AddGrade('b');
            employee.AddGrade(60);
            employee.AddGrade('C');
            employee.AddGrade('E');
          //  employee.AddGrade(0);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Min, 20);
        }

       
    }
}