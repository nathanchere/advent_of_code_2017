# Advent of Code 2017
# Day 01: "Inverse Captcha" (Python)

from common import *

def solve(input):
    result=0
    input=input + input[0]
    for x in range(len(input) - 1):
        if input[x] == input[(x + 1)]:
            result += int(input[x])
    return result

class Tests():
    import pytest

    def test_example_1(x):
        assert solve('1122') == 3

    def test_example_2(x):
        assert solve('1111') == 4

    def test_example_3(x):
        assert solve('1234') == 0

    def test_example_4(x):
        assert solve('91212129') == 9

    def test_solve(x):
        assert solve(get_input('day01'))

if __name__ == "__main__":
    print(solve(get_input('day01')))
