using Base.Test
__precompile__(true)

function getInput(challenge)
    open("../../challenges/$challenge") do f
        content=readstring(f)
        return content
    end
end

function isTest()
    return length(ARGS) > 0 && ARGS[1] == "test"
end

macro do_test(input, expected)
    return :(
        if isTest()
            @test solve($input) == expected
        end
    )
end

macro do_solve(input)
    return :(
        if isTest()
            @test solve($input) == nothing
        else
            println(solve($input))
        end
    )
end
