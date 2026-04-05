using System;
namespace NtAI
{
  class Logic
  {
    public static void Call()
    {
      bool run = true;
      while(run)
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
        else if (input.Contains("hi") || input.Contains("hello"))
        {
          Console.WriteLine("Hi there! Can I help you?");
        }
        else if (input.Contains("your name") || input.Contains("ur name"))
        {
          Console.WriteLine("My Name is NtAI");
        }
        else if (input.Contains("bye") || input.Contains("goodbye"))
        {
          Console.WriteLine("Bye! See you again!");
          run = false;
        }
        else if (input.Contains("AI"))
        {
          Console.WriteLine("AI is... But i'm not AI,I'm rule based");
        }
        else if (input.Contains("like programming") || input.Contains("love programming"))
        {
          Console.WriteLine("Me too! C# is awesome,isn't it?");
        }
        else
        {
          Console.WriteLine($"I don't know about '{input}',please talk about something else");
        }
      }
    }
  }
}

