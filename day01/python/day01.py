# Advent of Code 2017
# Day 01: "Inverse Captcha" (Python)

import os

def get_input(day):
    with open(f'../{day}.input','r') as f:
        return f.read()

if __name__ == "__main__":
    print(get_input('day01'))
