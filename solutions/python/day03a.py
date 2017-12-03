# Advent of Code 2017
# Day 03: "Spiral Memory" Part 1 (Python)

from common import *
import re

def solve(input):
    if input == 1:
        return 1

    print("---------------------")
    print("Doing : {}".format(input))
    steps=1
    squareof=1
    while squareof*squareof < input:
        steps+=1
        squareof+=2
    squaredval = squareof*squareof

    print('steps:{} squareof:{} squaredval:{}'.format(steps, squareof, squareof*squareof))

    outersteps = squaredval - ((squareof-2)*(squareof-2))
    startcount = squaredval - outersteps + 1
    sidelength = int(outersteps * 0.25)

    # 2-axis symmetrical from here so don't care which side it comes from

    print('uppertbound: {} stepsinrow: {}, startfrom: {}, sidelength: {}'.format(squaredval, outersteps, startcount, sidelength))

    newtarget = input
    while newtarget >= startcount + sidelength:
        newtarget -= sidelength

    balancepoint=startcount+(int(0.5*sidelength)) -1
    print('newtarget: {}, balancepoint={}'.format(newtarget,balancepoint))

    stepsx = steps-1

    if newtarget > balancepoint:
        stepsy =  newtarget - balancepoint
    else:
        stepsy = balancepoint - newtarget

    print('stepsx={}, stepsy={}'.format(stepsx, stepsy))
    print('result: {} steps'.format(stepsx+stepsy))
    return stepsx+stepsy


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
    print(solve(265149))


