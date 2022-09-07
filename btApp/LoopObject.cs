using System;

namespace btApp
{
    internal class LoopObject
    {
        public void bai1()
        {
            Console.WriteLine("99");
        }
        public void bai2()
        {
            Console.WriteLine("8");
        }
        public void bai3()
        {
            Console.WriteLine();
        }
        public void bai4()
        {
            Console.WriteLine("50");
        }
        public void bai5()
        {
            int n;
            string textCase;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cau: ");
            textCase = Console.ReadLine();
            Console.WriteLine("S = " + Const.getS(n, textCase));
        }
        public void bai6()
        {
            Console.WriteLine("Input number: ");
            int n = int.Parse(Console.ReadLine());
            Const.binaryDivide(n);
            
        }
        public void bai7()
        {
            Const.bai7();

        }
        public void bai8()
        {
            Const.checkShhLeftThan1000();
        }
        public void bai9()
        {

            Const.checkNSNT();

        }
        public void bai10()
        {
            Const.getDoubleNumber();
        }
        public void bai11()
        {
            Const.countU();
        }
    }
}