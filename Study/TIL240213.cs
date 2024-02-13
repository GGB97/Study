using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIL240213
{
    public class dotoweenTest : MonoBehaviour
    {
        void Start()
        {
            // DOMoveX(this Transform target, float endValue, float duration, bool snapping = false)
            // target = 움직여야 할 대상(생략 가능), endValue = 목표 위치 값, duration = 몇 초 동안 이동할지,
            // snapping = 이 값이 true로 설정되면 Tween이 완료될 때 대상의 위치가 소수점 이하의 값으로 조정되지 않습니다 <- 이건 잘 모르겠음. 기본값은 false

            // 예시
            transform.DOMoveX(10, 3f); // X좌표 10 의 위치로 3초동안 이동
            transform.DOLocalMoveX(10, 3f); // 자신 기준으로 X축을 10만큼 3초동안 이동.


            // 목표 위치까지 도달하는 움직임을 SetEase(Ease)로 조절 할 수 있음. 기본값은 Ease.Linear(목표값까지 균등한 속도로 이동)
            // https://m.blog.naver.com/dooya-log/221320177107 해당 링크의 [Ease] 목차를 가면 그래프 형식으로 볼 수 있음.
            transform.DOLocalMoveX(100, 2f).SetEase(Ease.Linear);

            // OnComplete(action) <- 매개변수가 없는 함수를 매개변수로 넣을 수 있음
            // 이 함수는 OnComplete에 전달한 함수를 DoLocalMoveX의 움직임이 끝났을 때 실행시켜준다.
            // 일종의 Invoke(Method Name, duration) 과 비슷 한 것 같음.
            transform.DOLocalMoveX(100, 2f).OnComplete(() => { });

            // 이런 식으로도 사용이 가능 함
            transform.DOLocalMoveX(100, 2f).SetEase(Ease.Linear).OnComplete(() => { });
        }
    }
}
