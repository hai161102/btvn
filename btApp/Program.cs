using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace btApp
{
    internal class Program
    {
        static ConditionObject condition;
        static LoopObject loop;
        static void Main(string[] args)
        {
            condition = new ConditionObject();
            loop = new LoopObject();
            setOptionClick();
            Console.ReadKey();
        }
        static void setOptionClick()
        {
            int firstOption = -1;
            do
            {
                

                Console.WriteLine("Choose options you want: ");
                Console.WriteLine("1. Condition");
                Console.WriteLine("2. Loop");
                Console.WriteLine("0. Exit");
                firstOption = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (firstOption)
                {
                    case 0:
                        break;
                    case 1:
                        setOptionClickCondition();
                        break;
                    case 2:

                        setOptionClickLoop();
                        break;
                    default:
                        break;
                }
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("\nChoose another options");
            } while (firstOption != 0);
        }

        private static void setOptionClickLoop()
        {
            Console.WriteLine("Choose number of case");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("bai " + (i + 1) +":");
            }
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    loop.bai1();
                    break;
                case 2:
                    loop.bai2();
                    break;
                case 3:
                    loop.bai3();
                    break;
                case 4:
                    loop.bai4();
                    break;
                case 5:
                    loop.bai5();
                    break;
                case 6:
                    loop.bai6();
                    break;
                case 7:
                    loop.bai7();
                    break;
                case 8:
                    loop.bai8();
                    break;
                case 9:
                    loop.bai9();
                    break;
                case 10:
                    loop.bai10();
                    break;
                case 11:
                    loop.bai11();
                    break;
                case 12:
                    loop.bai12();
                    break;
                default:
                    break;
            }
           
        }

        private static void setOptionClickCondition()
        {
            Console.WriteLine("Choose number of case");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("bai " + (i + 1) + ":");
            }
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    condition.bai1();
                    break;
                case 2:
                    condition.bai2();
                    break;
                case 3:
                    condition.bai3();
                    break;
                case 4:
                    condition.bai4();
                    break;
                case 5:
                    condition.bai5();
                    break;
                case 6:
                    condition.bai6();
                    break;
                case 7:
                    condition.bai7();
                    break;
                case 8:
                    condition.bai8();
                    break;
                case 9:
                    condition.bai9();
                    break;
                case 10:
                    condition.bai10();
                    break;
                case 11:
                    condition.bai11();
                    break;
                case 12:
                    condition.bai12();
                    break;
                case 13:
                    condition.bai13();
                    break;
                case 14:
                    condition.bai14();
                    break;
                case 15:
                    condition.bai15();
                    break;
                case 16:
                    condition.bai16();
                    break;
                case 17:
                    condition.bai17();
                    break;
                case 18:
                    condition.bai18();
                    break;
                case 19:
                    condition.bai19();
                    break;
                case 20:
                    condition.bai20();
                    break;
                default:
                    break;
            }
        }
    }
}
