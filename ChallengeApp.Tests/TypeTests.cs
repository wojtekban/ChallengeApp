namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestWhenToAddIntegersThenCompareIfTheyAreEqual()
        {
            //arrange
            float number1 = 10;
            float number2 = 10;

            //act


            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void TestWhenToAddDecimalNumbersThenCompareIfTheyAreEqual()
        {
            //arrange
            double number1 = 3.14;
            double number2 = 3.14;

            //act


            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void WhenToAddNumbersThenCompareIfTheyAreEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act


            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void WhenToAddUsersThenCompareIfTheyAreEqual()
        {
            //arrange
            var user1 = GetEmployee("Adam", "Wilczewski", 30);
            var user2 = GetEmployee("Kasia", "Lisewska", 25);

            //act


            //assert
            Assert.AreNotEqual(user1, user2);

        }
        private Employee GetEmployee(string name, string surName, int age)
        {
            return new Employee(name, surName, age);
        }
    }
}
