# Advent of Code 2017
# Day 02: "Corruption Checksum" Part 1 (Python)

from common import *
import re

def solve(input):
    result = 0
    for line in input.splitlines():
        result += get_row_difference(line)
    return result

def get_row_difference(input):
    minValue=999999999999
    maxValue=0
    regex = re.compile("[^\t]+")
    for value in regex.findall(input):
        numberValue = int(value)
        if numberValue > maxValue:
            maxValue = numberValue
        if numberValue < minValue:
            minValue = numberValue
    return maxValue - minValue


class Tests():
    import pytest

    def test_example(x):
        assert solve(get_example_input('day02a')) == 18

    def test_solve(x):
        assert solve(get_input('day02'))

if __name__ == "__main__":
    print(solve(get_input('day02')))
