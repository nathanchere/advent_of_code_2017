# Advent of Code 2017
# Day 01: "Inverse Captcha" (Elixir)

defmodule Day01A do

  def solve(input) do
    "OK"
  end
end

ExUnit.start
defmodule Day01ATests do
  use ExUnit.Case

  import Common

  test "Example" do
    assert Day01A.solve("1122") == 3
  end

  test "Solution" do
    input=Common.get_input("day01.input")
    Day01A.solve(input)
  end
end
#
# Day01A.solve("day01.input")
# |> IO.puts
