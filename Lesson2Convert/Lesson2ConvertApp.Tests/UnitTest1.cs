using Lesson2ConvertApp;

namespace Lesson2ConvertApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var converterStrToInt = new ConverterStrToInt();
            int result = converterStrToInt.Converter("0");
            Assert.Equal(0, result);
        }
    }

}