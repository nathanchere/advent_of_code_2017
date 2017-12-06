# Advent of Code 2017 - Julia template

include("common.jl")

function solve(input)
    return input
end

# I haven't worked out how to force all the tests to always
#   run with this approach, so it will stop at the first failed
#   test. If you know how to fix this while still keeping the
#   individual solution files clear of noise, please let me know.

# do_test and do_solve are macros defined in common.jl

@do_test 1337 1337
@do_test getInput("template.input.example") "13"
@do_solve getInput("template.input")

