---
filename: learnbf.bf
contributors:
    - ["Prajit Ramachandran", "http://prajitr.github.io/"]
    - ["Mathias Bynens", "http://mathiasbynens.be/"]
translators:
    - ["JongChan Choi", "http://0xABCDEF.com/"]
    - ["Peter Lee", "http://peterjlee.com/"]
---

Brainfuck(문장을 시작하는 단어가 아닌이상 첫글자는 대문자를 사용하지 않습니다)은
여덟가지 명령어만으로 튜링-완전한 최소주의 프로그래밍 언어입니다.

```bf
"><+-.,[]" 이외의 문자들은 무시됩니다. (쌍따옴표는 제외)

브레인퍽은 30,000 칸 짜리의 0으로 초기화된 배열과,
현재 칸을 가르키는 포인터로 표현됩니다.

여덟가지의 명령어는 다음과 같습니다:
+ : 포인터가 가르키는 현재 칸의 값을 1 증가시킵니다.
- : 포인터가 가르키는 현재 칸의 값을 1 감소시킵니다.
> : 포인터가 다음 칸(오른쪽 칸)을 가르키도록 이동시킵니다.
< : 포인터가 이전 칸(왼쪽 칸)을 가르키도록 이동시킵니다.
. : 현재 칸의 값을 ASCII 문자로 출력합니다. (즉, 65 = 'A')
, : 하나의 문자를 입력받고 그 값을 현재 칸에 대입합니다.
[ : 현재 칸의 값이 0이면 짝이 맞는 ] 명령으로 넘어갑니다.
    0이 아니면 다음 명령어로 넘어갑니다.
] : 현재 칸의 값이 0이면 다음 명령어로 넘어갑니다.
    0이 아니면 짝이 맞는 [ 명령으로 다시 돌아갑니다.

[이랑 ]은 while 루프를 만들어냅니다. 무조건, 짝이 맞아야 합니다.

몇가지 간단한 브레인퍽 프로그램을 보겠습니다.

++++++ [ > ++++++++++ < - ] > +++++ .

이 프로그램은 문자 'A'를 출력합니다. 처음에는, 반복할 횟수를 정하기 위한 값을
만들기 위해 첫번째 칸의 값을 6으로 증가시킵니다. 그리고 루프로 들어가서([)
두번째 칸으로 넘어갑니다. 루프 안에서는 두번째 칸의 값을 10 증가시키고,
다시 첫번째 칸으로 넘어가서 값을 1 감소시킵니다. 이 루프는 여섯번 돕니다.
(첫번째 칸의 값을 6번 감소시켜서 0이 될 때 까지는 ] 명령을 만날 때마다
루프의 시작 지점으로 돌아갑니다)

이 시점에서, 두번째 칸의 값은 60이고, 포인터는 값이 0인 첫번째 칸에 위치합니다.
여기서 두번째 칸으로 넘어간 다음 값을 5 증가시키면 두번째 칸의 값이 65가 되고,
65는 문자 'A'에 대응하는 아스키 코드이기 때문에, 두번째 칸의 값을 출력하면
터미널에 'A'가 출력됩니다.

, [ > + < - ] > .

이 프로그램은 사용자로부터 문자 하나를 입력받아 첫번째 칸에 집어넣습니다.
그리고 루프에 들어가서, 두번째 칸으로 넘어가 값을 한 번 증가시킨 다음,
다시 첫번째 칸으로 넘어가서 값을 한 번 감소시킵니다.
이는 첫번째 칸의 값이 0이 될 때까지 지속되며,
두번째 칸은 첫번째 칸이 갖고있던 값을 가지게 됩니다.
루프가 종료되면 포인터는 첫번째 칸을 가르키기 때문에 두번째 칸으로 넘어가고,
해당 아스키 코드에 대응하는 문자를 출력합니다.

또한 공백문자는 순전히 가독성을 위해서 작성되었다는 것을 기억하세요.
다음과 같이 작성해도 똑같이 돌아갑니다:

,[>+<-]>.

한 번 돌려보고 아래의 프로그램이 실제로 무슨 일을 하는지 맞춰보세요:

,>,< [ > [ >+ >+ << -] >> [- << + >>] <<< -] >>

이 프로그램은 두 개의 숫자를 입력받은 뒤, 그 둘을 곱합니다.

위 코드는 일단 두 번의 입력을 받고, 첫번째 칸의 값만큼 바깥 루프를 돕니다.
그리고 루프 안에서 다시 두번째 칸의 값만큼 안쪽의 루프를 돕니다.
그리고 그 루프에서는 세번째 칸의 값을 증가시키는데, 문제가 하나 있습니다:
내부 루프가 한 번 끝나게 되면 두번째 칸의 값은 0이 됩니다.
그럼 다시 바깥 루프를 돌 때에 안쪽의 루프를 돌지 않게 되는데, 이를 해결하려면
네번째 칸의 값도 같이 증가시킨 다음, 그 값을 두번째 칸으로 옮기면 됩니다.
그러면 세번째 칸에 곱셈의 결과가 남습니다.
```

여기까지 브레인퍽이었습니다. 참 쉽죠?
재미삼아 브레인퍽 프로그램이나 다른 언어로 브레인퍽 인터프리터를 작성해보세요.
인터프리터 구현은 간단한 편인데,
사서 고생하는 것을 즐기는 편이라면 한 번 작성해보세요… 브레인퍽으로.