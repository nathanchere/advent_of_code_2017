using System;
using System.IO;
using System.ComponentModel;
using System.Reflection;

namespace Aoc2017
{
    public class Program
    {
        static void Main(string[] args)
        {
          if(args.Length == 0)
          {
            Console.WriteLine("Usage: dotnet run {challenge}");
            Console.WriteLine("eg: dotnet run day01b");
            return;
          }

          var day = args[0];
          Console.WriteLine(Directory.GetCurrentDirectory());
          var type = Assembly.GetEntryAssembly().GetType($"Aoc2017.{day}");
          var challenge = (Challenge)Activator.CreateInstance(type);
          var result = challenge.Solve();
          Console.WriteLine(result);
        }
    }

    public abstract class Challenge
    {
      public abstract string Solve();

      protected string GetInput(string filename)
      {
        return File.ReadAllText($"../..{filename}");
      }
    }
}
