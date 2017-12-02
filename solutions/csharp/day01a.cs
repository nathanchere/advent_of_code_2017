// Advent of Code 2017
// Day 01: "Inverse Captcha" (C#)

using Xunit;
using System;
using System.Linq;

namespace Aoc2017
{
  public class day01a : Challenge
  {
    public override string InputFilename => "day01.input";

    public override string Solve() => Solve(GetInput());

    public string Solve(string input)
    {
      var result = 0;
      for (int i=0; i<input.Length-1; i++) {
        if(input[i]==input[i+1])
        result += Int32.Parse(input[i].ToString());
      }
      if(input[0]==input[input.Length-1])
        result += Int32.Parse(input[0].ToString());
      return result.ToString();
    }

    [Fact]
    public void Example01() => Assert.Equal("3", Solve("1122"));

    [Fact]
    public void Example02() => Assert.Equal("4", Solve("1111"));

    [Fact]
    public void Example03() => Assert.Equal("0", Solve("1234"));

    [Fact]
    public void Example04() => Assert.Equal("9", Solve("91212129"));

    [Fact]
    public void TrySolution() => Solve(GetInput());
  }
}