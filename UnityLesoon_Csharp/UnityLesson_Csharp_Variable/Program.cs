using System;

namespace UnityLesson_Csharp_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Person 
    {
        // 필드 : 타입(자료형) 변수이름(대소문자 구분함)
        // Person 클래스의 멤버 변수
        int age;                 // 나이 (정수형)
        float height;            // 키 (실수형)
        bool isResting;          // 쉬고있는가? (논리형) - 참과 거짓으로 나눌 수 있는 형태
        char genderChar;         // 성별 문자 (문자형)
        string name;             // 이름 (문자열형)
    }
}
