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
            ConverterStrToInt convertStrToInt = new();
            
            try
            {
                int num = convertStrToInt.Converter(str);
                Console.WriteLine($"Введенное значение {num} преобразовано в тип {num.GetType()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите число");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
        }
    }
}