# Advent of Code 2017
# Day 01: "Inverse Captcha" Part 1 (Julia)

using Base.Test
include("common.jl")

function solve(input)
    println(input)
end

if isTest()
    @testset "Foo Tests" begin
        @test solve(getInput("day01.input.example"))
        @test solve(getInput("day01.input")) == nothing
    end
else
    solve("day1.input")
end
