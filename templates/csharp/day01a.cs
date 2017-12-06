// Advent of Code 2017 - C# template

using Xunit;
using System;
using System.Linq;

namespace Aoc2017
{
  // Note that the naming (and casing) convention is important so that the
  // bootstrap code in Program.cs can find each challenge solution

  public class day01a : Challenge
  {
    // This is so the Program.cs entry point doesn't need to know what
    //   input file to use when attempting the real solution
    public override string Solve() => Solve(GetInput("day01.input"));

    public string Solve(string input)
    {
      return "0";
    }

    [Fact]
    public void Example01() => Assert.Equal("3", Solve("1122"));

    [Fact]
    public void Example02() => Assert.Equal("4", GetInput("day2a.input.example"));

    [Fact]
    public void TrySolution() => Solve();
  }
}