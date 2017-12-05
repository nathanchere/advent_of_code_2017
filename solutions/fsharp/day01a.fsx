// Advent of Code 2017
// Day 01: "Inverse Captcha" Part 1 (F#)

#r "Expecto.dll"

open System
open System.IO
open Expecto

let getInput challenge =
  sprintf "../../challenges/%s" challenge
    |> File.ReadAllLines
    |> String.concat("")

let isTest =
  match fsi.CommandLineArgs with
  | [|_;"test"|] -> true
  | _ -> false

let solve input =
  printfn "%s" input
  0

[<Tests>]
let myTests =
  test "one test" {
    Expect.equal (2+3) 4 "2+2"
  }

  test "another test that fails" {
    Expect.equal (3+3) 5 "3+3"
  }

solve(getInput("day01.input"))

//runTestsWithArgs defaultConfig argv myTests
printfn "args: %A" fsi.CommandLineArgs
printfn "%b" isTest

