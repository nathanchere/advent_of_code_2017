# Advent of Code 2017
# Day 02: "Corruption Checksum" Part 1 (Python)

from common import *
import re

def solve(input):
    steps=1
    squareof=2
    while squareof*squareof <= input:
        steps+=1
        squareof+=2
    print('{} {} {}'.format(steps, squareof, squareof*squareof))

    return squareof


class Tests():
    import pytest

    def test_example1(x):
        assert solve(9) == 2

    def test_example2(x):
        assert solve(10) == 3

    def test_example3(x):
        assert solve(3) == 2

    def test_solve(x):
        assert solve(265149)

if __name__ == "__main__":
    print(solve(get_input(265149)))


