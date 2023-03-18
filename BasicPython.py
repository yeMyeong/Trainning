# input, 형변환
num = int(input("아무 자연수나 입력하세요"))

# if 문
if num > 1000:
    print("n은 1000보다 큰 수 입니다")
elif num > 100:
    print("n은 1000 미만 100 초과입니다.")
else:
    print("n은 100 미만 0 이상입니다.")

# 리스트
a = [1, 3, 5, 7, 8, 13, 20, 25]

print(len(a)) # a의 길이를 출력하시오

# for 문 : a의 각 값들을 출력
for b in a:
    print(b)

# for, if 복합 : a의 각 값에서 짝수만 출력하시오
for c in a:
    if c % 2 == 0:
        print(c)