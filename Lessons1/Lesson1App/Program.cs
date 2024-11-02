
namespace Lesson1App
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new();
            int result = calculator.Add(5, 3);
            Console.WriteLine($"Сумма {result}");
        }
        
    }
}