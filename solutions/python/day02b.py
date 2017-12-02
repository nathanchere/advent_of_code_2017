# Advent of Code 2017
# Day 02: "Corruption Checksum" Part 2 (Python)

from common import *
import re

def solve(input):
    result = 0
    for line in input.splitlines():
        result += get_row_checksum(line)
    return result

def get_row_checksum(input):
    regex = re.compile("[^\t]+")
    values = list(map(int, regex.findall(input)))
    for x in range(0,len(values)):
        for y in range(x+1,len(values)):
            if values[x] == values[y]:
                continue;
            if values[x] > values[y]:
                result = values[x] / values[y]
            if values[y] > values[x]:
                result = values[y] / values[x]
            if result % 1 == 0:
                return result;

class Tests():
    import pytest

    def test_example(x):
        assert solve(get_example_input('day02b')) == 18

    def test_solve(x):
        assert solve(get_input('day02'))

if __name__ == "__main__":
    print(solve(get_input('day02')))