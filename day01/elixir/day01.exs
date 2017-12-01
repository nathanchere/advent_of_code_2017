# Advent of Code 2017
# Day 01: "Inverse Captcha"

defmodule Day01 do

  defp get_input(file_name) do
    File.read!(file_name)
    |> String.split(", ")
  end

  def main(file_name) do
    get_input(file_name)
    |> IO.puts
  end
end

# expected:
Day01.main("../day01.input.example")
Day01.main("../day01.input")
