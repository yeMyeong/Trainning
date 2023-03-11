﻿using System;

namespace Lv0_The_conditions_for_completion_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
            가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다.
            삼각형의 두 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.
            나머지 한 변이 될 수 있는 정수의 개수를 return하도록 solution 함수를 완성해주세요.

            제한사항
            sides의 원소는 자연수입니다.
            sides의 길이는 2입니다.
            1 ≤ sides의 원소 ≤ 1,000
            
            sides = [1, 2];
            result = 1;
             
            */

            int[] sides = { 1000, 1000 };
            int answer = 0;
            
            if (sides[0] > sides[1]) // a가 가장 큰 경우
            {
                for (int i = 0; i < sides[0]; i++)
                {
                    if (sides[0] < sides[1] + i)
                        answer++;
                }
            }
            else if (sides[0] < sides[1]) // b가 가장 큰 경우
            {
                for (int i = 0; i < sides[1]; i++)
                {
                    if (sides[1] < sides[0] + i)
                        answer++;
                }
            }

            for (int i = 2; i < sides[0] + sides[1]; i++) // c가 가장 큰 경우
            {
                if (sides[0] > sides[1]) // a가 가장 큰 경우
                {
                    if (i > sides[0])
                        answer++;
                }
                else if (sides[0] < sides[1]) // b가 가장 큰 경우
                {
                    if (i > sides[1])
                        answer++;
                }
            }


            answer++;
            Console.WriteLine(answer);
        }
    }
}
