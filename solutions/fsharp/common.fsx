open System
open System.IO
open Xunit

let getInput challenge =
  File.ReadAllLines("../../challenges/day01.input")