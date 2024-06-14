namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling func...");
            Console.WriteLine( func("") );

            Console.WriteLine( Sum());
        }


        static int func(String p)
        {
            return p.Length;
        }

        public static int Sum()
        {
            var i = 0;
            var result = 0;
            while (true)
            {
                result += i;
                i++;
            }
            return result;
        }
    }
}