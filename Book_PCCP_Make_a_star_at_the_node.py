line = [[2, -1, 4], [-2, -1, 4], [0, -1, 1], [5, -8, -12], [5, 8, 12]]

x = 0
y = 0

for i in range(len(line) - 1):
    if line[i][0] * line[i+1][1] - line[i][1] * line[i+1][0] != 0:
        x = line[i][1] * line[i+1][2] - line[i][2] * line[i+1][1] / 