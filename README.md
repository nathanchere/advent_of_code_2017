# Advent of Code 2017 solutions

Just sharing my solutions for Advent of Code 2017.

I don't claim to be fluent in any of these langauges except C#. If you see something I'm doing which is very obviously wrong or even just can suggest a more efficient or idiomatic approach in one of the other languages, the feedback is appreciated.

## Repository structure

`./challenges` contains challeng descriptions, example input and challenge input

`./solutions` contains the code for the solutions sorted into folders by languages as follows.

### C#

All C# code is in `./solutions/csharp`. Solutions assume .Net Core 2.0.

Run specific solutions with e.g. `dotnet run day01b`

Run tests with `dotnet test`

### Elixir

Solutions assume Elixir 1.5

### Kotlin

All Kotlin code is in `./solutions/kotlin`. Solutions assume Kotlin

### Python

All C# code is in `./solutions/python`. Solutions assume Python 3.6.

Run `pip install pytest` to enable unit test support

Run solutions with e.g. `python day01.py`

Run tests with `py.test day01.py`

### Scala

hm.. maybe

## Misc tips

If adding your own input files using Atom, configure or disable the `whitespace` package to stop newlines being added to the end of input files when saved.