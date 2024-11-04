/*


*/


namespace Lesson2ConvertApp
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string? str = Console.ReadLine();
            ConverterStrToNum converterStrToNum = new();
            
            try
            {
                var numInt = converterStrToNum.ConverterStrToInt(str);
                Console.WriteLine($"Введенное значение {numInt} преобразовано в тип {numInt.GetType()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите число");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }

            Console.WriteLine("Введите число");
            str = Console.ReadLine();
            var numDouble = ConverterStrToNum.ConverterStrToDouble(str);
            Console.WriteLine(Math.Round(numDouble, 2));

        }
    }
}