using System;

namespace Progect2
{
    
    
    class Program
    {
        static void Main(string[] agrs)
        {
            B a = new B(81);        //B a = new B { x = 2 };
            B b = new B(13);        //B b = new B { x = 5 };

            Console.WriteLine("a * b ");
            B g = a * b;
            Console.WriteLine(g.x);

            Console.WriteLine("a > b : ");
            bool re = a > b;
            Console.WriteLine(re);

            Console.WriteLine("a < b : ");
            bool r = a < b;
            Console.WriteLine(r);

            if (a && b)
                Console.WriteLine("a && b истино");
            else 
                Console.WriteLine("a && b ложно");
            if (a || b)
                Console.WriteLine("a || b истино");
            else 
                Console.WriteLine("a || b ложно");


        }
    }
    class B
    {
        //public int x { get; set; }

        public int x;
        public B()
        {
            x = 0;
        }
        public B (int i)
        {
            x = i;
        }
        
        public static B operator *(B a, B b)
        {
            return new B { x = a.x * b.x };
        }

        public static bool operator >(B a, B b)
        {
            if (a.x > b.x)
                return true;
            else
                return false;
        }

        public static bool operator <(B a, B b)
        {
            if (a.x < b.x )
                return true;
            else
                return false;
        }


        public static B operator &(B a, B b)
        {
            if (a.x != 0 & b.x != 0)
                return new B (1);
            else
                return new B(0);
        }

        public static B operator |(B a, B b)
        {
            if (a.x != 0 | b.x != 0)
                return new B(1);
            else
                return new B(0);
        }

       
        public static bool operator true(B c)
        {
            if (c.x != 0)
                return true;
            else
                return false;
        }
        public static bool operator false(B c)
        {
            if (c.x == 0)
                return true;
            else
                return false;
        }
    }
}
