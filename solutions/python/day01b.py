# Advent of Code 2017
# Day 01: "Inverse Captcha" Part 2 (Python)

from common import *

def solve(input):
    result =0
    input_size = len(input)
    offset = input_size * 0.5
    for x in range(len(input)):
        if input[x] == input[int(x + offset) % input_size]:
            result += int(input[x])
    return result

class Tests():
    import pytest

    def test_example_1(x):
        assert solve('1212') == 6

    def test_example_2(x):
        assert solve('1221') == 0

    def test_example_3(x):
        assert solve('123425') == 4

    def test_example_4(x):
        assert solve('123123') == 12

    def test_example_5(x):
        assert solve('12131415') == 4

    def test_solve(x):
        assert solve(get_input('day01'))

if __name__ == "__main__":
    print(solve(get_input('day01')))
