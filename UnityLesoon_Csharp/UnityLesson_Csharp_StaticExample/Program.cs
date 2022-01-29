using System;

namespace UnityLesson_Csharp_StaticExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc = new Orc();
            orc.name = "오크";
            orc.Jump();

            Orc.typeName = "오크타입";
            Orc.SayTypeName();
           
        }
    }
    public class Orc
    {
        static public string typeName;
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;

        static public void SayTypeName()
        {
            Console.WriteLine(typeName);
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다");
        }
        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다");
        }
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
