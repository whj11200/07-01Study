using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _07_01CSharp
{
    internal class Laught
    {
        static int Sum(params int[] args)
        {
            int sum = 0;
            foreach (int arg in args)
            {
                sum += arg;
            }
            return sum;
        }
        //로컬함수는 메서드 안에서 선언되고 메서드 안에서 
        // 사용되는 특별한 함수 
        // 클래스 멤버가 아니기 때문에 메서드가 아니라 
        // 함수라고 부른다.
        // 가변길이 매개변수 혹은
        // 가변길이 인자
        // 로컬함수: 메서드 안에 로컬함수선언같은 기능
        // 반복적으로 연계되어 있는 겨우 로컬함수라 쓰임
        // 출력 전용 매개 변수 ref , out
        // enum 열거형 상수 
        // 가독성을 위해서 문자는 개발자가 읽고 컴파일러는 숫자로 읽는다.

       static string ToLowerToString(string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerCher(i);
            }
            char ToLowerCher(int i)
            {
                // A~ Z의 아스키 값 : 65에서 90
                if (arr[i] < 65 || arr[i]>90 )
                    return arr[i];
                else // a ~ z ASCII 값 : 97에서 122
                    // 대문자와 소문자의 숫자 차이는 32차이다.

                    return (char)(arr[i]+32);
            }
            return new string(arr);

        }

        public static void Main(string[] args)
        {
            #region 가변길 인수 혹은 가변길이 매개변수
            //int total = 0;
            //total = Sum(1, 2);
            //Console.WriteLine($"{total}");
            //total = Sum(1, 2, 3, 4);
            //Console.WriteLine($"{total}");
            //total = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //Console.WriteLine($"{total}");
            #endregion
            #region 로컬함수
            Console.WriteLine(ToLowerToString("GOOD MONING MOTHER FUCKERS"));
            Console.WriteLine(ToLowerToString("hahahah"));
            #endregion
        }
    }
}
