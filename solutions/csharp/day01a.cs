// Advent of Code 2017
// Day 01: "Inverse Captcha" (C#)

using Xunit;

namespace Aoc2017
{
  public class day01a : ISolution
  {
    public string Solve(string input)
    {
      return input;
    }

    [Fact]
    public void Example01() => Assert.Equal("3", Solve("1122"));
  }
}