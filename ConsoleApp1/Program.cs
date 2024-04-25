namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEV
            Console.WriteLine("Hello, DEV!");

#elif PROD
            Console.WriteLine("Hello, PROD!");
#else
            Console.WriteLine("Hello, Default!");

#endif
            Console.ReadLine();
        }
    }
}
