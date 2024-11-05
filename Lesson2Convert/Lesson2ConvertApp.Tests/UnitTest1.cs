using Lesson2ConvertApp;

namespace Lesson2ConvertApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var converterStrToInt = new ConverterStrToNum();
            int result = converterStrToInt.ConverterStrToInt("0");
            Assert.Equal(0, result);
        }

    }

    public class UnitTest2
    {
       
        [Fact]
        public void Test2()
        {
            var str = "3,784";
            Assert.Equal(3.784, ConverterStrToNum.ConverterStrToDouble(str));
        }
    }

}