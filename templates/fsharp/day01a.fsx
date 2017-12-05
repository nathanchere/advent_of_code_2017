// Advent of Code 2017 F# Template

// Expecto.dll is a unit testing library. The DLL is included
//   here to remove the need for referencing through nuget'
//   package which adds additional steps and noise to running
//   solutions.
// common.fsx is used to store common boiletplate code moved
// into its own file to minimise noise in each solution.

#r "Expecto.dll"
#load "common.fsx"
open Common
open Expecto

let solve input =
  // Write your solution here
  0

[<Tests>]
let tests =
  testList "Tests" [
    // "Example" tests allow you to check your solution
    //   against the known inputs and answers provided with each
    //   challenge.
    // The "Solve" test is basically just to check that your
    //   solution runs without crashing, stack overflow,
    //   out of memory etc.
    // For simple tests, just pass in the test value directly
    // For tests with larger input data,
    test "Example" { Expect.equal (solve "1234") 0 }
    test "Solve" { solve(getInput("day01.input")) }
  ]

// isTest, doTests and getInput are helper methods
//   included in common.fsx

if isTest then
  doTests tests
else
  solve(getInput("day01.input"))