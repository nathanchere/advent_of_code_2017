# Advent of Code 2017 - Python template

from common import *

def solve(input):
    return input

class Tests():
    import pytest
    def test_example_1(x): assert solve(13) == 13
    def test_example_2(x): assert solve(get_input('template.input.example')) == '13'
    def test_solve(x): assert solve(get_input('template.input'))

if __name__ == "__main__":
    print(solve(get_input('template.input')))
