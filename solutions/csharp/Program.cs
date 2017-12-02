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
          var day = args[0];
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
        return File.ReadAllText($"{filename}");
      }
    }
}
