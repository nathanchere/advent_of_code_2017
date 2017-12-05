#r "Expecto.dll"

open System
open System.IO
open Expecto

let getInput challenge =
  File.ReadAllLines("../../challenges/day01.input")

