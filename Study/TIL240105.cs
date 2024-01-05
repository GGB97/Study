using System;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

public class TIL240105
{
    // 2024 01 05 새로 배운 것
    public void file()  // 파일 입출력은 txt 파일로 C에서 해 본적이 있는데 c에 비하면 적어야 하는게 압도적으로 적다;;
    {
        // 파일 입출력 System.IO.File
        string filename = "파일경로 + 이름 + 확장자";
        string saveStr = "저장 할 내용";

        // 파일 생성
        File.WriteAllText(filename, saveStr);

        // 해당 경로에 파일이 있는지 확인
        if (File.Exists(filename))
        {
            // 파일 읽어오기
            string str = File.ReadAllText(filename);

            // 저장 한 내용과 읽어온 파일의 내용이 일치하는 지 확인
            if (saveStr == str)
            {
                Console.WriteLine("성공적으로 저장되었습니다.");
            }
            else
            {
                Console.WriteLine("알수없는 이유로 저장에 실패하였습니다.");
            }
        }
        else            // 이런식으로 파일이 성공적으로 저장이 되었는지 확인 할 수 있다.
        {
            Console.WriteLine("저장에 실패하였습니다.");
        }
    }

    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // 만약 클래스 내부에 사용자 임의 클래스가 더 있다면
        // 해당 클래스의 직렬화 함수를 제공하는 사용자 정의 클래스를 생성 후
        // 해당 문자열을 보관하는 변수를 가진 사용자 정의 클래스를 만드는 방식으로 사용 할 수 있다.
    }
    // using System.Text.Json;
    void Serialize_DeSerialize()    // 직렬화_역직렬화
    {
        // 객체 생성
        Person person = new Person { Name = "Alice", Age = 30 };

        // 직렬화
        string jsonString = JsonSerializer.Serialize(person);   // 이 방식은 그냥 한줄로 쭉~~~~~~ 나열 되어 있다.

        var option = new JsonSerializerOptions() { WriteIndented = true };  // 여기서 option은 
        jsonString = JsonSerializer.Serialize(person, option);  // 이 방식을 사용하면 보기 좋게 나누어져서 정리된다.


        // 직렬화된 JSON 출력
        Console.WriteLine(jsonString);

        // 역직렬화하여 객체로 다시 변환
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);

        // 역직렬화된 객체 속성 출력
        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
    }

    //Newtonsoft.Json;
    void Serialize_DeSerialize2()
    {
        // 객체 생성
        Person person = new Person { Name = "Bob", Age = 25 };

        // 직렬화
        string jsonString = JsonConvert.SerializeObject(person);    // 위와 같이 한줄로 나열되어있는 형식

        // Newtonsoft.Json은 System.Text.Json보다 더 많은 옵
        jsonString = JsonConvert.SerializeObject(person, Formatting.Indented);  // 들여쓰기를 적용하는 형식
        // Newtonsoft.Json.Formatting 열거형 멤버들
        // None: 들여쓰기 없이 한 줄로 JSON 문자열을 출력합니다.
        // Indented: 들여쓰기가 적용된 보기 좋은 형태로 JSON 문자열을 출력합니다.
        // Compact: 간결한 형태의 JSON 문자열을 출력합니다. 
        //          이 옵션은 Newtonsoft.Json의 일부 버전에서 사용되지만 지원이 중단된 경우도 있습니다.


        // 직렬화된 JSON 출력
        Console.WriteLine(jsonString);
        /*          출력 예시 (한줄의 경우에는 그냥 한줄로 쭉 적혀있다)
        {
            "Name": "Bob",
            "Age": 25
        }
        */


        // 역직렬화하여 객체로 다시 변환
        Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonString);

        // 역직렬화된 객체 속성 출력
        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
    }

}
