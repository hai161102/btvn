using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
        public void bai4()
        {
            Console.WriteLine("50");
        }
        public void bai5()
        {
            Console.WriteLine("Nhap cau a, b, c, hoac d: ");
            string caseText = Console.ReadLine();
            Console.WriteLine("Nhap N: ");
            Console.WriteLine("Kq: " + Const.getS(int.Parse(Console.ReadLine()), caseText));
        }
        public void bai6()
        {
            Console.WriteLine("Nhap N: ");
            Const.binaryDivide(int.Parse(Console.ReadLine()));
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
