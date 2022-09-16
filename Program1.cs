using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Проект 1
{
    class Program
    {
        class Date
        {
            private
                string y;

            public void Input()
            {
                Console.WriteLine("Input year:");
                y = Console.ReadLine();
            }
            public int Convertacion()
            {
                int y1;
                y1 = Convert.ToInt32(y);
                return y1;

            }
        }

        static void Main(string[] args)
        {
            string d, m;

            Date D = new Date();

            Console.WriteLine("Input day:");
            d = System.Console.ReadLine();

            Console.WriteLine("Input mounth:");
            m = System.Console.ReadLine();

            D.Input();
            
            int d1, m1, y1;

            d1 = Convert.ToInt32(d);
            m1 = Convert.ToInt32(m);
            y1 = D.Convertacion();
            IsValid(d1, m1, y1);
            
        }

        static void IsValid(int a, int b, int c)
        {
            
            if(b < 1 || b > 12)
            {
                Console.WriteLine("This date does not exist!");
            }
            if(c % 4 == 0 )
            {
                if(b == 2)
                {
                    if (a >= 1 && a <= 29)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    } 
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                        
                }

                if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
                {
                    if (a >= 1 && a <= 31)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    }
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                }

                if (b == 4 || b == 6 || b == 9 || b == 11)
                {
                    if (a >= 1 && a <= 30)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    }
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                }
            }
            else
            {
                if (b == 1 || b == 3 || b == 5 || b == 7 || b == 8 || b == 10 || b == 12)
                {
                    if (a >= 1 && a <= 31)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    }
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                }

                if (b == 4 || b == 6 || b == 9 || b == 11)
                {
                    if (a >= 1 && a <= 30)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    }
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                }

                if(b == 2)
                {
                    if(a >= 1 && a <=28)
                    {
                        Console.WriteLine($"Set date: {a}.{b}.{c}");
                    }
                    else
                    {
                        Console.WriteLine("This date does not exist!");
                    }
                }
            }

        }
    }
}
