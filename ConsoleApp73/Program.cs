namespace ConsoleApp73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling func...");
            func("");
        }


        int func(String p)
        {
            return p.Length;
        }
    }
}