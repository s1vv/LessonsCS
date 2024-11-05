namespace Lesson1App.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            int result = calculator.Add(a, b);

            Assert.Equal(8, result);
        }
    }

}
