using System;

namespace NtAI
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("===== Welcome to NtAI =====");
            Console.WriteLine("Type 'exit' or quit to exit program");
            
            try
            {
                Logic.Call();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nOpps!: {ex.Message}");
                Console.ResetColor();
                
                #if DEBUG
                Console.WriteLine($"\n{ex.StackTrace}");
                #endif
                
                Console.WriteLine("\nPress any keys to exit...");
                Console.ReadKey();
            }
        }
    }
}
