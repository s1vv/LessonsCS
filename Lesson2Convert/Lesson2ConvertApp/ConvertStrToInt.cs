/*
1. **Простая конвертация строки в целое число**
   - **Задача**: Напишите программу, которая принимает строку от пользователя и конвертирует её в целое число (`int`). Если ввод не является числом, выведите сообщение об ошибке.
   - **Цель**: Закрепить базовые знания о классе `Convert` и обработке исключений.
*/
namespace Lesson2ConvertApp
{
    public class ConverterStrToNum
    {
        public int ConverterStrToInt(string? str)
        {
            return Convert.ToInt32(str);
        }
        public static double ConverterStrToDouble(string? str)
        {
            try
            {
                double num = Convert.ToDouble(str);
                Console.WriteLine($"Введенное значение {num} преобразовано в тип {num.GetType()}");
                return num;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите число");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e}");
            }
            return double.NaN;
        }
    }

}