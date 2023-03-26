array = [3, 28, 12]
n = 20
a = 0

array.sort()
sub = []

for i in array:
    if i >= n:
        sub.append(i - n)
    else:
        sub.append(n - i)

a = sub.index(min(sub))

print(array[a])

