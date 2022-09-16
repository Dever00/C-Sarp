//Верхоланцев Д.А.
using System;


namespace Лаба__4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            try
            {
                int x;
                int y;
                Console.WriteLine("Введите 1 число: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите 2 число: ");
                y = int.Parse(Console.ReadLine());


                int z = Math.BigMul(x, y);
                Console.WriteLine(x + " * " + y + " = " + z);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Значение выходит за пределы.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Ошибка преобразования.");
            }
            
        }


    }
}
