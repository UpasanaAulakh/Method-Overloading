using System;

namespace Method_Overloading
{
    class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static float add(float a, float b)
        {
            return a + b;
        } 
         
    public    static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(23,98));
            Console.WriteLine(Cal.add(27.4f, 9.65f));
        }
    }
}
