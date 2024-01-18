using System;

public class TIL240118
{
    /* Unity InputSystem 패키지
          * Unity Input System은 Unity에서 입력 처리를 담당하는 새로운 시스템
            2019.1 버전부터 새로 도입되었으며, 기존의 Input 클래스보다 더 유연하고 확장 가능한 입력 처리를 제공
            다양한 입력 소스를 통합하고 처리하기 위해 설계되었으며, 게임 패드, 키보드, 마우스, 터치 스크린, 가속도계 등을 지원 
            플랫폼 별로 입력 방식을 수정하기가 용이함

            GameObject에 PlayInput 컴포넌트를 붙여야함.

            Create -> input Action 생성
                생성한 input Action 을 열고 Controll Schemes 생성

              * ActionMaps -> Action의 그룹화? 인것 같음

              * Actions -> Action이 어떤 종류의 데이터를 생성하는지 나타내는 것. Action Type은 주로 입력 값의 유형을 정의
                    Action Type -> 액션에 등록한 입력이 들어올때 전달할 값
                        Value -> 연속적인 값을 가지는 입력, 스틱의 좌표, 마우스의 움직임과 같이 연속적인 입력을 다룰 때 사용 
                        Button -> 주로 이진(on/off) 상태의 입력을 나타냄, 버튼이 눌린 상태인지 아닌지를 나타낸다
                        Pass Through -> 입력 값을 변형하지 않고 그대로 전달하는 형태, 대부분의 원시 입력을 다루기 위해 사용. (원시입력? 이건뭐임)

                    Control Type -> 입력에 사용되는 하드웨어 장치나 터치 입력의 세부적인 종류를 나타냅니다. Control Type은 주로 어떤 형태의 입력 값을 받아들일지 결정
                        Vector2,3 -> On*** 함수가 실행 될때 필요한 변수인 InputValue의 값 인것 같은데 조금 더 익숙해져봐야 알 것 같음. <- 아직 Vector2밖에 안써봄
                        Button -> 이진(on/off) 상태를 가진 입력, 일반적으로 키보드의 키나 게임패드의 버튼과 관련됩니다.
                        Stick -> 연속적인 입력 값을 가진 입력, 주로 조이스틱이나 마우스와 관련됩니다.
                        Touch -> 터치 입력에 사용되는 Control Type으로, 주로 스마트폰이나 태블릿에서 사용됩니다.

              * input Action -> Schemes -> Action Maps -> Action 안에 정의 된 이름들 ex)Move, Look, Fire 같은 입력이 감지 될 때 저 이름들 앞에 On*** 이런식의 함수가 있다면 그 함수를 실행시킴.
                                        평균적으로 많이 사용하는 방식에 대해서도 알아봐야 할 것 같음.
    
     * 
     * ScriptableObject
          * 데이터를 저장하고 관리하는데 사용되는 클래스            (기존에는 CommonData 클래스를 하나 만들어서 사용했는데 그런 느낌으로 사용하면 될 것 같음)
            게임 오브젝트와는 달리 씬에 속하지 않으며
            프로젝트 내에서 재사용 가능한 데이터를 정의하고 유지할 때 유용함
            주로 게임의 설정, 리소스, 에셋, 툴 등을 저장하는 데 활용
           
          * 쉬운 직렬화(Serialization): ScriptableObject는 직렬화가 간편하며, 데이터를 쉽게 파일이나 메모리에 저장하고 로드할 수 있습니다.
            재사용 가능한 데이터 정의: ScriptableObject를 사용하면 데이터를 정의하고 이를 다양한 오브젝트에서 공유할 수 있습니다. 여러 스크립트나 씬에서 동일한 데이터를 사용해야 하는 경우 유용합니다.
            간단한 에디터 확장: ScriptableObject는 에디터에서 사용자 정의된 에디터 창을 통해 데이터를 효과적으로 편집하고 시각화할 수 있는 장점이 있습니다.
            리소스로 쉽게 로드: ScriptableObject는 리소스 폴더에 저장하여 에셋으로 취급되어 쉽게 로드할 수 있습니다.
               
          * [CreateAssetMenu(fileName, menuName, order)]
                fileName: 생성될 ScriptableObject의 기본 파일 이름
                menuName: 에디터 메뉴에서 어디에 위치할지 (유니티 Create창 최상단에 위치) "A\B\C" <- 이런경로식으로 입력
                order: 메뉴에서의 순서. 낮은 숫자가 높은 우선순위
     *
     

     * [Header(string)]
          * 유니티 인스펙터 창에 제목? 같은 느낌으로 표시 해줌
            한개의 변수만이 아니라 연속으로 선언된 변수들도 포함
     * 
     */
}
