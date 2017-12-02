defmodule Aoc2017.Mixfile do
  use Mix.Project

  def project do
    [
      app: :advent_of_code_2017,
      version: "0.1.0",
      elixir: "~> 1.5",
      start_permanent: Mix.env == :prod,
    ]
  end

end