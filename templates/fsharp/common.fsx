#r "Expecto.dll"
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

let doTests tests =
  runTests defaultConfig tests