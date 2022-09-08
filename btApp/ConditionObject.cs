using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btApp
{
    internal class ConditionObject
    {

        public void bai1()
        {
            Console.WriteLine("Nhap ky tu: ");
            Console.WriteLine(Const.findSyntax(Console.ReadLine().ToCharArray()[0]));
        }
        public void bai2()
        {
            Console.WriteLine("Nhap so nguyen: ");

            Console.WriteLine(Const.whatIsNumber(int.Parse(Console.ReadLine())));
        }
        public void bai3()
        {
            Console.WriteLine();
        }
        public void bai4()
        {
            Console.WriteLine("Nhap x: ");
            Console.WriteLine("f(x) = " + Const.fourth(float.Parse(Console.ReadLine())));
        }
        public void bai5()
        {
            int a1, a2, b1, b2, c1, c2;
            Console.WriteLine("Nhap a1: ");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b1: ");
            b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c1: ");
            c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap a2: ");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b2: ");
            b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c2: ");
            c2 = int.Parse(Console.ReadLine());

            Const.ptBN2A(a1, b1, c1, a2, b2, c2);
        }
        public void bai6()
        {
            Console.WriteLine("How many number: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] listNumber = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap so thu " + (i + 1));
                listNumber[i] = int.Parse(Console.ReadLine());
            }
            int[] getMaxMin = Const.getMaxAndMin(listNumber);
            Console.WriteLine("Max: " + getMaxMin[0] + "; Min: " + getMaxMin[1]);
        }
        public void bai7()
        {
            Console.WriteLine("Nhap a, b, c");
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            Const.isTriangle(a, b, c);
        }
        public void bai8()
        {
            Const.printSort();
        }
        public void bai9()
        {
            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());

            while (!(number < 1000 && number >= 100))
            {
                Console.WriteLine("Input number again because it less than 100 or great than 999: ");
                number = int.Parse(Console.ReadLine());
            }
            Const.onTheNumber(number);

        }
        public void bai10()
        {
            Console.WriteLine("Input day in week: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine(Const.getDayInWeek(day));
        }
        public void bai11()
        {
            Const.getMonthAndYear();
        }
        public void bai12()
        {
            Const.isHopLe();
        }
        public void bai13()
        {
            Const.bai13on1();
        }
        public void bai14()
        {
            Const.bai14on1();
        }
        public  void bai15()
        {
            Console.WriteLine("Nhap so km: ");
            Console.WriteLine("Gia la: " + Const.taxiPay(int.Parse(Console.ReadLine())));
        }
        public void bai16()
        {
            bai7();
        }
        public void bai17()
        {
            Const.checkSnt();
        }
        public void bai18()
        {
            Const.checkShh();
        }
        public void bai19()
        {
            Const.checkScp();
        }

        internal void bai20()
        {
            throw new NotImplementedException();
        }
    }
}
