using StandardMultipleLibrary;
using System;

namespace MultipleFrameworks
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new MultiFrameworks();

            Console.WriteLine($"Platform: {library.Platform}");
            Console.WriteLine($"Version: {Environment.Version}");
            Console.WriteLine("Press return to exit...");
            Console.ReadLine();
        }

        
    }
}
