using System;

namespace UnityLesson_Csharp_InstantiationOfClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 객체의 멤버 변수 초기화
            person1.age = 40;
            person1.height = 223.0f;
            person1.isResting = true;
            person1.name = "Test";
            person1.genderChar = '여';
            //객체의 멤버 변수 호출
            person1.SayAllInfo();


            Person person2 = new Person();
            person1.age = 29;
            person1.height = 293.0f;
            person1.isResting = false;
            person1.name = "Test2";
            person1.genderChar = '남';
            person1.SayName();
        }
    }
    public class Person
    {
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        public void SayAllInfo()
        {
            SayAge();
            SayHeight();
            SayIsResting();
            SayGenderChar();
            SayName();
        }
        public void SayAge()
        {
            Console.WriteLine($"{name} 의 나이 : {age}");
        }
        public void SayHeight()
        {
            Console.WriteLine($"{name} 의 키 : {height}");
        }
        public void SayIsResting()
        {
            Console.WriteLine($"{name} 는 쉬고 있나? : {isResting}");
        }
        public void SayGenderChar()
        {
            Console.WriteLine($"{name} 의 성별 : {genderChar}");
        }
        public void SayName()
        {
            Console.WriteLine($"{name} 의 이름 : {name}");
        }
    }
}
