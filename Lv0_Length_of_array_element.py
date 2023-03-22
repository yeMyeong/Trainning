# 문자열 배열 strlist가 매개변수로 주어집니다.
# strlist 각 원소의 길이를 담은 배열을 retrun하도록
# solution 함수를 완성해주세요.

strlist = ["We", "are", "the", "world!"]
answer = [ 0 for i in range(len(strlist))]

for i in range(len(strlist)):
    answer[i] = len(strlist[i])

print(answer)

# 다른 풀이
answer2 = []

for i in strlist:
    answer2.append(len(i))

print(answer2)