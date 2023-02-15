namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestAverage()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski", 30);
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(-1);
            employee.AddGrade(7);
            employee.AddGrade(6);
            employee.AddGrade(-20);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Average, 0);
        }
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestMax()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski",30);
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(-1);
            employee.AddGrade(7);
            employee.AddGrade(6);
            employee.AddGrade(-20);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Max, 7);
        }
        [Test]
        public void WhennEmployeeGetGradeStatisticsTestMin()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski", 30);
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(-1);
            employee.AddGrade(7);
            employee.AddGrade(6);
            employee.AddGrade(-20);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(statistics.Min, -20);
        }

       
    }
}