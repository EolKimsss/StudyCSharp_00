using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 예외가 발생할 가능성이 있는 로직
                Console.WriteLine("값을 입력하세요 : ");
                string input = Console.ReadLine();
                float result = float.Parse(input);
                Console.WriteLine($"입려된 값은 {result} 입니다.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"예외발생{e.Message}");
                
            }



        }
    }
}
