# Advent of Code 2017
# Day 01: "Inverse Captcha" (Elixir)

defmodule Day01A do

  def solve(_) do
    "OK"
  end

end

ExUnit.start
defmodule Day01ATests do
  use ExUnit.Case
  import Common

  test "Example1", do: assert Day01A.solve("1122") == 3
  test "Example2", do: assert Day01A.solve("1111") == 4
  test "Example3", do: assert Day01A.solve("1234") == 0
  test "Example4", do: assert Day01A.solve("91212129") == 9
  test "Solution", do: get_input("day01.input") |> Day01A.solve()
end

# Day01A.solve("day01.input")
# |> IO.puts
