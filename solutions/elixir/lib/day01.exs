# Advent of Code 2017
# Day 01: "Inverse Captcha" (Elixir)

defmodule Day01A do

  import Common

  def main(filename) do
    Common.get_input(filename)
    |> IO.puts
  end
end

ExUnit.start

defmodule Day01ATests do
  use ExUnit.Case

  test "Example" do
    assert Day01.main() == :world
  end

  test "Solution" do
    assert Day01.main() == :world
  end
end

Day01A.main("day01.input")
