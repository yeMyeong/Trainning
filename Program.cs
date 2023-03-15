using System;

namespace Lv0_Ctrl_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Lv.0 컨트롤 제트

            숫자와 "Z"가 공백으로 구분되어 담긴 문자열이 주어집니다.
            문자열에 있는 숫자를 차례대로 더하려고 합니다.
            이 때 "Z"가 나오면 바로 전에 더했던 숫자를 뺀다는 뜻입니다.
            숫자와 "Z"로 이루어진 문자열 s가 주어질 때,
            머쓱이가 구한 값을 return 하도록 solution 함수를 완성해보세요.

            입출력 예 ( s => result)
            "1 2 Z 3" => 4
            "10 20 30 40" => 100
            "10 Z 20 Z 1" => 1
            "10 Z 20 Z" => 0
            "-1 -2 -3 Z" => -3
             */

            string s = "1 2 Z 3";
            int answer = 0;

            string[] arr = s.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == "Z")
                {
                    arr[i - 1] = "0";
                    arr[i] = "0";
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                answer += int.Parse(arr[i]);
            }

            Console.WriteLine(answer);
        }
    }
}
