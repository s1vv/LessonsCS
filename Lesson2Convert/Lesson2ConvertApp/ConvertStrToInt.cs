/*
### 1. **Простая конвертация строки в целое число**
   - **Задача**: Напишите программу, которая принимает строку от пользователя и конвертирует её в целое число (`int`). Если ввод не является числом, выведите сообщение об ошибке.
   - **Цель**: Закрепить базовые знания о классе `Convert` и обработке исключений.

*/
namespace Lesson2ConvertApp
{
    public class ConverterStrToInt
    {
        public int Converter(string str)
        {
            return Convert.ToInt32(str);
        }
    }
}