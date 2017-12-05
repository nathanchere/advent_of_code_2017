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

module Day01A =

  let solve input =
    printfn "%s" input

  [<Tests>]
  let myTests =
    testCase "will run" <| fun () -> Expect.equal (2+2) 4 "2+2"

Day01A.solve(getInput("day01.input"))
