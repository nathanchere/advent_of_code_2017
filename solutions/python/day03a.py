# Advent of Code 2017
# Day 03: "Spiral Memory" Part 1 (Python)

from common import *
import re

def solve(input):
    print("---------------------")
    print("Doing : {}".format(input))
    steps=1
    squareof=1
    while squareof*squareof <= input:
        steps+=1
        squareof+=2
    print('{} {} {}'.format(steps, squareof, squareof*squareof))

    squaredval = squareof*squareof
    outersteps = squaredval - ((squareof-1)*(squareof-1))

    print('uppertbound: {} stepsinrow: {}'.format(squaredval, outersteps))

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
    print(solve(3))
    print(solve(9))
    print(solve(15))
    #print(solve(265149))


