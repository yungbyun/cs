## C# 프로그래밍

* 2022학년도 C# 프로그래밍 강의 깃허브입니다. 반갑습니다.

## (Code 1) 아래 C++ 프로그램을 C# 프로그램으로 바꿔보세요.
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

## (Code 2) 다음 코드에서 Click은 xxx 함수를 실행할 수 있는 델리게이트이다. 델리게이트 Click을 사용할 수 있도록 코드를 적절히 수정하세요. 
```
using System;

public class Base
{
	public void xxx()
	{
		Console.WriteLine("클릭!");
	}
}
public class Delegate
{
	public static void Main()
	{
		Base gildong = new Base();
		gildong.Click(); //Click은 xxx 함수의 델리게이트
	}
}
```



