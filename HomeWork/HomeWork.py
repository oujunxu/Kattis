# My solution to Homework problem in Kattis.com

pages_to_read = input().split(";")  # split all the incoming input with a ";" if it exists.

total = 0  # to count the total amount of problems

# loop through all the numbers to increment total with 1 for every problem.
for n in pages_to_read:
    if "-" in n:
        pages_sub = n.split("-")
        total += (int(pages_sub[1]) - int(pages_sub[0]) + 1)
    else:
        total += 1

print(total)
