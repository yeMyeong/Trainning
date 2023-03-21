"""패밀리 레스토랑에 가서, 여러 개의 테이블에 사람을 나누어 앉게 하려고 합니다.
이 때, 한 사람만 앉는 테이블이 없게 그룹을 지어야 합니다.
인원수를 나누는 패턴만 구하면 되며, 누가 어디에 앉는지 등은 고려하지 않아도 괜찮습니다.
예를 들어 6명이라면, 다음과 같은 4가지가 됩니다.

2명 + 2명 + 2명
2명 + 4명
3명 + 3명
6명

한 개의 테이블에 앉을 수 있는 사람은 최대 10명입니다.
100명이 하나 이상의 테이블에 나누어 앉는 패턴을 구하세요."""

m = 10
n = 100

def check(remain, pre):
    if remain < 0:
        return 0
    elif remain == 0:
        return 1
    cnt = 0
    for i in range(pre, m + 1):
        cnt += check(remain - i, i)
    return cnt

print(check(n, 2))