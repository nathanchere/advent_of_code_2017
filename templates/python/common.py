import os

def get_input(day):
    with open(f'../../challenges/{day}','r') as f:
        return f.read()