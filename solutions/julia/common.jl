function getInput(challenge)
    open("../../challenges/$challenge") do f
        content=readstring(f)
        return content
    end
end