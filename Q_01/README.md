# 1번 문제

주어진 프로젝트 내에서 CubeManager 객체는 다음의 책임을 가진다
- 해당 객체 생성 시 Cube프리팹의 인스턴스를 생성한다
- Cube 인스턴스의 컨트롤러를 참조해 위치를 변경한다.

제시된 소스코드에서는 큐브 인스턴스 생성 후 아래의 좌표로 이동시키는 것을 목표로 하였다
- x : 3
- y : 0
- z : 3

제시된 소스코드에서 문제가 발생하는 `원인을 모두 서술`하시오.

## 답안
- 1. 스크립트가 Awake 될때 큐브가 생성되어야 하는데 Start 에서 큐브가 생성되게 돼 있어서 작동하지 않았다. 먼저 Awake 라이프사이클에서 큐브가 생성되어야 했다.
- 2. SetCubePosition() 함수에서 매개변수를 float x, float y, float z 를 쓰게 했지만 정작 이동되는 함수는 SetPosition()가 이동을 수행하는 함수이기 때문에 매개변수를 SetPosition() 에 지정해주고, 벡터도 지정해주면 된다.