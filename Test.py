# 프로그래머스 Lv0_짝수 홀수 개수

# 정수가 담긴 리스트 num_list가 주어질 때,
# num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.

num_list = [1, 2, 3, 4, 5]
answer = [0, 0]

for n in num_list:
    if n % 2 == 0:
        answer[0] += 1
    else:
        answer[1] += 1

print(answer)
