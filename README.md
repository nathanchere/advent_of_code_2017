# Advent of Code 2017 solutions

Just sharing my solutions for Advent of Code 2017.

I don't claim to be fluent in any of these langauges except C#. If you see something I'm doing which is very obviously wrong or can suggest a more efficient and/or idiomatic approach in any of the  other languages, the feedback would be appreciated.

## Repository structure

`./challenges` contains challeng descriptions, example input and challenge input

`./solutions` contains the code for the solutions sorted into folders by languages as follows.

## Languages attempted

### C# (https://docs.microsoft.com/en-us/dotnet/csharp/)

All C# code is in `./solutions/csharp`. Solutions assume .Net Core 2.0.

Run specific solutions with e.g. `dotnet run day01b`

Run tests with `dotnet test`

### Elixir (http://elixir-lang.github.io)

Solutions assume Elixir 1.5

### Kotlin (https://kotlinlang.org)

All Kotlin code is in `./solutions/kotlin`. Solutions assume Kotlin

### Julia (https://julialang.org)

All Julia code is in `./solutions/julia`. Solutions assume Julia 0.6.

Run specific solutions with e.g. `julia day01b.jl`.

Run tests with e.g `julia day01b.jl test`

### LOLCODE

OK seriously, fuck this language. Even for a joke language it's a complete and utter turd.

### Python (https://www.python.org)

All Python code is in `./solutions/python`. Solutions assume Python 3.6.

Run `pip install pytest` to enable unit test support

Run solutions with e.g. `python day01.py`

Run tests with `py.test day01.py`

## Misc tips

If adding your own input files using Atom, configure or disable the `whitespace` package to stop newlines being added to the end of input files when saved.

PS: thanks to https://andrewlock.net/fixing-the-error-program-has-more-than-one-entry-point-defined-for-console-apps-containing-xunit-tests/ for salvaging my sanity while setting up the .Net Core test project
