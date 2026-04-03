using System;
namespace NtAI
{
  class Logic
  {
    static void Call()
    {
      bool run = true;
      while(true)
      {
        Console.Write("You: ");
        string input = Console.ReadLine()?.Trim().ToLower() ?? "";
        Console.Write("AI: ");
        if(input == "exit" || input == "quit")
        {
          run = false;
        }
        else if (string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Sorry,I can't hear that.");
        }

        else
        {
          Console.WriteLine($"I don't know about '{input}',please talk about something else");
        }
      }
    }
  }
}

