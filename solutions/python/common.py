import os

def get_input(day):
    with open(f'../../inputs/{day}.input','r') as f:
        return f.read()

def get_example_input(day):
    with open(f'../../inputs/{day}.input.example','r') as f:
        return f.read()
