using System;

public class TIL240130
{
    /*
     
    비트연산
    LayerMask layerMask = LayerMask.NameToLayer("layerName"); 이런식으로 저장하면 int값 ex)7 이들어감

    그래서
    layerMask.value == (layerMask.value | (1 << collision.gameobject.layer)) 를 하면
    전자는 int값으로 7 / 후자는 int 값으로 135로 저장이 됨 -> false

    layerMask를 인스펙터에서 선택하거나
    levelLayer =  1 << LayerMask.NameToLayer("Level"); 이런식으로 저장을 하면 위의 비교 방법으로 비교 가능

    혹은
    if (levelLayer.value == collision.gameObject.layer) // true
    이렇게 비교를 해도 됨

     */
}
