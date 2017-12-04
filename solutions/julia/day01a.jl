# Advent of Code 2017
# Day 01: "Inverse Captcha" Part 1 (Julia)

# include("common.jl")

function getInput(challenge)
    open("../../challenges/day01.input") do f
        content=readstring(f)
        return content
    end
end
input = getInput("day01a")
println(input)

# using JLTest
# @testcase begin
#     @casename "Example"
#     @test begin
#         @testname "A Simple Test" #Name of test (optional)
#         @assertEqual(1,1)
#     end
#     @test begin
#         @testname "Real test"
#         @assertEqual(2,1)
#     end
# end
