using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _07_01CSharp
{
    internal class ItemClass
    {

        
        static void Main(string[] args)
        {

            Console.WriteLine("입력");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);
            Console.WriteLine($"결과 값이? {Square(arg)}");
            double mean = Mean(1, 2, 3, 4, 5);
            Console.WriteLine($"평균: {mean}");
            
            int a = 3;
            int b = 4;
            int ruslut = 0;

            Plus(a, b,out ruslut);
            Console.WriteLine($"{a}+{b}={ruslut}");
            double x = 2.4;
            double y = 3.1;
            double ruslut2 = 0;

            Pluse(x, y, out ruslut2);
            Console.WriteLine($"{x}+{y}={ruslut2}");
            
        }
        static double Square(double arg)
        {
            return arg * arg;

        }
        static void Plus(int a , int b, out int c)
        {
            c = a + b;
        }
        static void Pluse(double x, double y, out double ruslut2)
        {
            ruslut2 = x + y;
        }
        static double Mean(double a, double b, double c, double d, double e)
        {
            return (a + b + c + d + e) / 5;
        }


    }
}
// 정렬 클래스
////enum Item
////{
////    Hp = 1,Spped,Wapen,Upgred
////}
////enum Animal
////{
////    Mouse,Cow,Tiger
////}
////enum Animals
////{
////    Horse,
////    Sheep = 5,
////    Monkey
////}
//Item items = new Item();
//switch (items)
//{
//    case Item.Hp:
//        Console.WriteLine("아이템 회복");
//        break;
//    case Item.Spped:
//        Console.WriteLine("스피드증가");
//        break;
//    case Item.Wapen:
//        Console.WriteLine("무기 장착");
//        break;
//    case Item.Upgred:
//        Console.WriteLine("업글");
//        break;
//}
//items = Item.Hp;
//Console.WriteLine(items);
//Animal animal = Animal.Tiger;
//Console.WriteLine(animal);
//if (animal == Animal.Tiger)
//{
//    Console.WriteLine("호랭이");
//} 
//Console.WriteLine((int)Animals.Monkey);