using System;
using System.IO;
using System.ComponentModel;
using System.Reflection;

namespace Aoc2017
{
    class Program
    {
        static string GetInput(string day)
        {
          return File.ReadAllText($"../../challenges/{day}.input");
        }

        static void Main(string[] args)
        {
          var day = args[0];
          var type = Assembly.GetEntryAssembly().GetType("Aoc2017.day01");
          var solution = (ISolution)Activator.CreateInstance(type);
          var result = solution.Solve(GetInput(day));
          Console.WriteLine(result);
        }
    }

    public interface ISolution
    {
      string Solve(string input);
    }
}
