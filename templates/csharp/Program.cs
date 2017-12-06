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

          if(args.Length == 2 && args[1] == "test")
          {
            --filter
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
        // because `dotnet run` is from project directory, but
        /// `dotnet test` is from project/bin/Debug/netcoreapp2.0... FML...
        var runPath = $"../../challenges/{filename}";
        var testPath = $"../../../../../challenges/{filename}";

        if(File.Exists(runPath))
          return File.ReadAllText(runPath);
        else
          return File.ReadAllText(testPath);
      }
    }
}