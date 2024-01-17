using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using static TIL240105;

public class Person
{
    [JsonProperty]  // <- 이 키워드로 인해 변환시 접근을 한다 (기본적으로는 public들만 변환하는 json 직렬화)
    private string name;
    public int age { get; set; }
    [JsonProperty]
    SubCalss sc;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        sc = new();
    }
}
public class SubCalss()
{
    [JsonProperty]
    private string name;
}

public class TIL240117
{
    void TIL()
    {
        /*
		기존에 직렬화/역직렬화 를 했을때는 class 내부에 있는 private 변수에 프로퍼티를 달기 싫어서 
                    (이유는 private 으로 선언한 이유가 외부에 노출을 하고싶지 않아서 였는데 
                    get; set; 을 만들게 되면 set은 private으로 한다고 해도 get은 외부에서 사용이 가능해서
                    get은 외부에서 사용한다고 해도 아무 상관이 없긴 하지만 
                    데이터 저장에서 밖에 사용하지 않는 get을 데이터 저장만을 위해 만드는게 뭔가 싫었다)

		해당 class에 대응하는 변환용 클래스를 생성 했엇지만
		  
		오늘 다른 사람들의 코드를 좀 보다보니까
		 
		2진파일로 저장을 하는 방식으로 하면 private 멤버변수도 수월하게 변환이 가능한걸 알았다.
        여기서 해보려 했는데 BinaryFormatter는 더이상 사용하지 않는다고 빨간줄이 나오는데..
            https://learn.microsoft.com/ko-kr/dotnet/fundamentals/syslib-diagnostics/syslib0011
        여기 나오는 내용 때문 인 것 같다. (대충 보안문제 인 것 같음)


        그리고 json으로 변환 할때에도 private 멤버 변수를 변환 가능한 방법도 검색하다보니 찾게되었다.
        [JsonProperty] <- 이 키워드를 private 변수 위에 붙여두면
        해당 변수는 public 으로 선언된 get; set; 프로퍼티가 존재하지 않아도
        변환이 가능하다.

        이 방법을 일주일만 빨리 알았다면 프로젝트에 변환용 class 들을 많이 만들지 않아도 되었을텐데..ㅋㅋ
        예시는 위 두개의 클래스 처럼 클래스 구조를 만들면 가능 
        (근데 이런게 있는거 보면 나같이 private에 프로퍼티를 다는게 싫은 사람이 좀 많은가? 싶기도 하고)
        */
    }
}

