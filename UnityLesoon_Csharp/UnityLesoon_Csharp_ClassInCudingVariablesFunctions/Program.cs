using System;

namespace UnityLesoon_Csharp_ClassInCudingVariablesFunctions
{
    internal class Program
    {
        class Person
        {
            int age;
            float height;
            bool isResting;
            char genderChar;
            string name;

            void SayAllInfo()
            {
                SayAge();
                SayHeight();
                SayIsResting();
                SayGenderChar();
                SayName();
            }
            void SayAge()
            {
                Console.WriteLine(age);
            }
            void SayHeight()
            {
                Console.WriteLine(height);
            }
            void SayIsResting()
            {
                Console.WriteLine(isResting);
            }
            void SayGenderChar()
            {
                Console.WriteLine(genderChar);
            }
            void SayName()
            {
                Console.WriteLine(name);
            }
        }

    }
}

