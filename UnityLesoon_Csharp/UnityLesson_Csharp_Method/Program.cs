using System;

namespace UnityLesson_Csharp_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();
            PrintSomething("집에 가고 싶다");
            bool tmpIsFinished = false;
            tmpIsFinished = PrintSomethingAndReturnIsFinished("집에 가고 싶죠");
            Console.WriteLine(tmpIsFinished)
;        }
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintSomething(string something)
        {
            Console.WriteLine(something);
        }
        static bool PrintSomethingAndReturnIsFinished(string something)
        {
            bool isFinished = false;
            Console.WriteLine(something);
            isFinished = true;
            return isFinished;
        }
    }
}
