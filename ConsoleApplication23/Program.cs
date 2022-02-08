using System;
using System .Threading;

namespace ConsoleApplication23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var x = 0;
            var y = 1;

            try
            {
                var z = y / x;
                Console.WriteLine(z);
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new ArgumentException("Sup bro");
            }
        }
    }
}