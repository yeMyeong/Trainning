"""문자열 before와 after가 매개변수로 주어질 때,
before의 순서를 바꾸어 after를 만들 수 있으면 1을,
만들 수 없으면 0을 return 하도록 solution 함수를 완성해보세요."""

before = "olleh"
after = "hello"

answer = 0
count = 0

for i in before:
    #for j in after:
        #if i == j:
    after = after.replace(i, "", 1)            
    #print(after)
if after == "":
    answer = 1
else:
    answer = -1

print(answer)
#after = after.replace("o", "")
#print(after)

# 다른 풀이
# 이게 시간복잡도가 더 낮을 듯하다

