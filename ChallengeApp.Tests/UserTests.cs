using System.Runtime.Intrinsics.X86;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhennEmployeeGetScore()
        {
            //arrange
            var employee = new Employee("Adam", "Wilczewski", 30);
            employee.AddScore(5);
            employee.AddScore(3);
            employee.AddScore(-1);
            employee.AddScore(7);
            employee.AddScore(6);
            employee.AddScore(-20);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);
        }

       
    }
}