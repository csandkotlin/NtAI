using System;
namespace NtAI
{
  class Logic
  {
    private static Random _random = new Random();

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
          string[] responses = { 
            "Hi there! Can I help you?", 
            "Hello! How's your day going?", 
            "Hey! What's up?" 
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
        }
        else if (input.Contains("your name") || input.Contains("ur name"))
        {
          string[] responses = { 
            "My name is NtAI", 
            "I'm NtAI, nice to meet you!", 
            "Call me NtAI" 
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
        }
        else if (input.Contains("bye") || input.Contains("goodbye"))
        {
          string[] responses = { 
            "Bye! See you again!", 
            "Goodbye! Have a great day!", 
            "See you later!" 
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
          run = false;
        }
        else if (input.Contains("AI"))
        {
          string[] responses = { 
            "AI is... But I'm rule-based, not AI", 
            "I'm just pattern matching, no AI here", 
            "Real AI? No, I'm simpler than that" 
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
        }
        else if (input.Contains("like programming") || input.Contains("love programming"))
        {
          string[] responses = { 
            "Me too! C# is awesome, isn't it?", 
            "Programming is fun! What's your favorite language?", 
            "Same here! C# is my favorite" 
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
        }
        else
        {
          string[] responses = { 
            $"I don't know about '{input}', please talk about something else",
            $"Sorry, I don't understand '{input}'",
            $"What does '{input}' mean? I'm just a simple bot"
          };
          Console.WriteLine(responses[_random.Next(responses.Length)]);
        }
      }
    }
  }
}
