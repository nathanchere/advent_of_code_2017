# Advent of Code 2017
# Day 01: "Inverse Captcha" (Python)

import pytest
import common

def solve(input):
    return 9

def test_example_1():
    assert solve('1122') == 9

def test_example_2():
    assert solve('1111') == 4

def test_example_3():
    assert solve('1234') == 0

def test_example_4():
    assert solve('91212129') == 9

def test_solve():
    assert solve(get_input('day01'))

if __name__ == "__main__":
    print(solve(get_input('day01')))
