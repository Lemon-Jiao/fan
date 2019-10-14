using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Add = Convert.ToInt32("+");
            //int Sub = Convert.ToInt32("-");
            //int Mul = Convert.ToInt32("*");
            //int Div = Convert.ToInt32("/");
            Computer com = new Computer();
            Console.WriteLine("请输入要进行的操作1、数值计算 2、字符串计算");
            int Q;
            Q= int.Parse(Console.ReadLine());
            if (Q == 1)
            {
                Console.WriteLine("请输入计算的x值");
                com.X = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入计算的y值");
                com.Y = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入要运算的符号");
                com.Str = Console.ReadLine();
                // switch()
                Console.WriteLine("计算的结果为：");
                if (com.Str == "+")
                {
                    com.Addition();
                }
                else if (com.Str == "-")
                {
                    com.Subtraction();
                }
                else if (com.Str == "*")
                {
                    com.Multiplication();
                }
                else if (com.Str == "/")
                {
                    com.Division();
                }
            }
            else
            {
                Console.WriteLine("请输入第一个字符串");
                com.Str1 = Console.ReadLine();
                Console.WriteLine("请输入第二个字符串");
                com.Str2 = Console.ReadLine();
                Console.WriteLine("请输入要运算的符号");
                com.Str = Console.ReadLine();
                if (com.Str == "+")
                {
                    com.AdditionStr();
                }
                else if (com.Str == "-")
                {
                    com.SubtractionStr();
                }
            }
            Console.ReadKey();
            //c{1}{2}{3}", Add, Sub, Mul, Div);
        }
        public class Computer
        {
            int x, y;
            string str;
            string str1, str2;
            public void Addition() //加法
            {
                Console.WriteLine(x + y); 
            }
            public void AdditionStr() //字符加法
            {
                Console.WriteLine(str1 + str2);
            }
            public void Subtraction()  //减法
            {

                Console.WriteLine( x- y);
            }
            public void SubtractionStr()  //字符减法
            {

                Console.WriteLine(str1.Replace(str2," "));
            }

            public void Multiplication() //乘法
            {
                Console.WriteLine(x * y);
            }
            public void Division() //除法
            {
                // return x / y;
                Console.WriteLine(x / y);
            }
            public void Equals()
            {

            }
            public void Equals(int x,int y)
            {
                if (x.Equals(y))
                {
                    Console.WriteLine("两个数相等");
                }
            }

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
            public string Str { get => str; set => str = value; }
            public string Str1 { get => str1; set => str1 = value; }
            public string Str2 { get => str2; set => str2 = value; }
        }
    }
}
