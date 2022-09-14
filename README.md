# C# 프로그래밍

* 2022학년도 C# 프로그래밍 강의 깃허브입니다. 반갑습니다.

## 아래 C++ 프로그램을 C# 프로그램으로 바꿔보세요.
```
#include <stdio.h>

class XXX 
{
private:
    int iX; 
    int iY; 

public:
    void Assign(int x, int y) {
        iX = x;
        iY = y;
    }

    int Add() {
        return iX + iY;
    }
};

XXX gildong;

void main() 
{
    gildong.Assign(2, 3);

    int iResult = gildong.Add();

    printf("두 개의 값을 더한 결과 : %d\n", iResult);
}
```
