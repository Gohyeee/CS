using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] arg)
            {
            int kor1, kor2, kor3; //변수 선언 : 이 기호들을 변수라고 선언하는 코드
            int total;
            float avg;

            //변수 초기화
            kor1 = 50;  //; = 실행 문장의 끝을 의미
            kor2 = 60;
            kor3 = 80;

            total = kor1 + kor2 + kor3;
            avg = total / 3;

            System.Console.WriteLine("total is {0}", total);
            System.Console.WriteLine("avg is {0}", avg); //콘솔 출력 API 함수

            /* 
            Ctrl+k+f : 코드 줄맞춤
            Shift+tab : 들여쓰기
            Ctrl+k+c : 한줄 주석
            Ctrl+k+u : 한줄 주석해제
            Ctrl+Shift+/ : 여러줄 주석
            코드 컴파일+실행 : Crtl+f5
             */
        }
    }
}
