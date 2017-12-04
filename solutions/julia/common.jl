function getInput(challenge)
    open("../../challenges/$challenge") do f
        content=readstring(f)
        return content
    end
end

function isTest()
    return length(ARGS) > 0 && ARGS[1] == "test"
end