using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btApp
{
    internal class Const
    {
        public static void giaiPTBac2(float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return;
            }
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem!");
            }
        }
        public static void showPtB2()
        {
            float a, b, c;
            Console.Write("Nhap he so bac 2, a = ");
            string valA = Console.ReadLine();
            a = Convert.ToInt32(valA);
            Console.Write("Nhap he so bac 1, b = ");
            string valB = Console.ReadLine();
            b = Convert.ToInt32(valB);
            Console.Write("Nhap he so bac 0, c = ");
            string valC = Console.ReadLine();
            c = Convert.ToInt32(valC);
            giaiPTBac2(a, b, c);
        }
        public static bool findSyntax(char text)
        {

            char[] chars = { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N',
        'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'x', 'X', 'y', 'Y', 'z', 'Z', 'w', 'W' };
            foreach (char i in chars)
            {
                if (text.Equals(i))
                {
                    return true;

                }
            }
            return false;

        }

        public static string whatIsNumber(int number)
        {
            string numberIs = "";

            if (number == 0)
            {
                numberIs = "0";
            }
            else if (number > 0)
            {
                numberIs = "pos";
            }
            else if (number < 0)
            {
                numberIs = "nev";
            }
            else if (number % 2 == 0)
            {
                numberIs = "chan";
            }
            else if (number % 2 != 0)
            {
                numberIs = "le";
            }
            return numberIs;
        }
        public static float fourth(float x)
        {
            if (x > 0)
            {
                if (x > -1 && x < 1)
                {
                    return 3 * x + 5;
                }
                return (float)(3 * x + Math.Sqrt(x));
            }
            else if (x <= 0)
            {
                if (x <= -1)
                {
                    return x * x + 2 * x - 1;
                }
                else if (x > -1 && x < 1)
                {
                    return 3 * x + 5;
                }
                else
                {
                    int k = 0;
                    float sum = 0;
                    float xMuK = x;
                    long g = 1;
                    float tmp = (float)(1.0 / g);
                    while (true)
                    {
                        sum += tmp;
                        k++;
                        xMuK = (float)Math.Pow(x, k);
                        g *= k;
                        tmp = xMuK / g;
                        if (tmp <= 0.0001)
                        {
                            break;
                        }
                    }
                    return (float)(sum + 4);
                }

            }


            return -1;
        }
        public static void ptBN2A(int a1, int b1, int c1, int a2, int b2, int c2)
        {
            int D = a1 * b2 - a2 * b1;
            int Dx = c1 * b2 - c2 * b1;
            int Dy = a1 * c2 - a2 * c1;

            if (D == 0)
            {
                if (Dx + Dy == 0)
                {
                    Console.WriteLine("Vo so nghiem");
                }
                else Console.WriteLine("Vo nghiem");
            }
            else
            {
                Console.WriteLine("x: " + (Dx / D) + ", y: " + (Dy / D));
            }
        }
        public static int[] getMaxAndMin(int[] arr)
        {
            int[] arr1 = new int[2];
            if (arr.Length >= 0)
            {
                if (arr.Length == 0)
                {
                    arr1[0] = 0;
                    arr1[1] = 0;
                }
                else if (arr.Length == 1)
                {
                    arr1[0] = arr[0];
                    arr1[1] = arr[0];
                }
                else
                {
                    int max = int.MinValue;
                    int min = int.MaxValue;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (max < arr[i])
                        {
                            max = arr[i];
                        }
                        if (min > arr[i])
                        {
                            min = arr[i];
                        }
                    }
                    arr1[0] = max;
                    arr1[1] = min;
                }
            }

            return arr1;
        }
        public static void isTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("equilateral triangle");
                    return;
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    if (a == b || b == c || a == c)
                    {
                        Console.WriteLine("Triangle right angle");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("It's right triangle");
                        return;
                    }

                }
                else if (a == b || a == c || c == b)
                {
                    Console.WriteLine("isosceles triangle");
                    return;
                }
                else
                {
                    Console.WriteLine("It's triangle");
                    return;
                }

            }
        }
        public static void printSort()
        {
            int a, b, c;
            Console.WriteLine("Input your 'a': ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input your 'b': ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input your 'c': ");
            c = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[] { a, b, c };
            sortArr(arr);
            string text = "";
            foreach (int item in arr)
            {
                text += item + " ";
            }
            Console.WriteLine(text);
        }
        public static void onTheNumber(int number)
        {
            string textNumber = number.ToString();
            int[] listNumber = new int[3];

            int i = 0;
            foreach (char item in textNumber)
            {
                listNumber[i] = int.Parse(item.ToString());
                i++;
            }
            sortArr(listNumber);
            Console.WriteLine("big number is: " + listNumber[2]);
            string text = "";
            foreach (int item in listNumber)
            {
                text += item + " ";
            }
            Console.WriteLine(text);
        }
        public static string getDayInWeek(int day)
        {
            switch (day)
            {
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thusday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                case 8:
                    return "Sunday";
                default:
                    return "NonDay";
            }
        }
        public static void getMonthAndYear()
        {
            Console.Write("Nhap thang : ");
            string Sthang = Console.ReadLine();
            Console.Write("Nhap nam : ");
            string Snam = Console.ReadLine();

            int th = int.Parse(Sthang);
            int nm = int.Parse(Snam);
            int songay = 0;

            if (th >= 1 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: songay = 31; break;
                    case 4:
                    case 6:
                    case 9:
                    case 11: songay = 30; break;

                    case 2:
                        if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
                            songay = 29;
                        else
                            songay = 28;
                        break;
                }

                Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            }
            else
                Console.Write("=> Thang khong hop le!\n");
            Console.ReadLine();
        }
        public static void isHopLe()
        {
            int ngay, thang, nam, ngaymax;
            ngaymax = 0;
            Console.WriteLine("Nhap ngay : ");
            ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thang : ");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap nam : ");
            nam = Convert.ToInt32(Console.ReadLine());

            if (nam < 0 || thang < 0 || thang > 12 || ngay < 0 || ngay > 31)
            {
                Console.WriteLine("Ngay khong hop le");
            }
            else
            {
                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        ngaymax = 31;
                        break;
                    case 2:
                        if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                            ngaymax = 29;
                        else
                            ngaymax = 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        ngaymax = 30;
                        break;
                }
                if (ngay <= ngaymax)
                {
                    Console.WriteLine("Ngay hop le!");
                }
                else
                {
                    Console.WriteLine("Ngay khong hop le!");
                }
            }
        }
        public static void bai13on1()
        {
            int gio, phut, giay;
            Console.WriteLine("Nhap gio:");
            gio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap phut:");
            phut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap giay:");
            giay = Convert.ToInt32(Console.ReadLine());
            if (gio < 0 || phut > 60 || giay > 60 || phut < 0 || giay < 0)
                Console.WriteLine("Khong hop le!");
            else
                Console.WriteLine("Hop le!");
        }
        public static void bai14on1()
        {

            Console.WriteLine("Nhap hinh muon tinh: ");
            string polygon = Console.ReadLine().ToLower();
            if (polygon.Contains("chu nhat") || polygon.Contains("chunhat") || polygon.Contains("nhat") || polygon.Contains("rect"))
            {
                shapeRect();
            }
            if (polygon.Contains("vuong") || polygon.Contains("hinh vuong") || polygon.Contains("hinhvuong") || polygon.Contains("square"))
            {
                shapeSquare();
            }
            if (polygon.Contains("tron") || polygon.Contains("oval"))
            {
                shapeOval();
            }
            if (polygon.Contains("tamgiac") || polygon.Contains("tam giac") || polygon.Contains("triangle"))
            {
                shapeTriangle();
            }

        }
        public static int taxiPay(int km)
        {
            int price = 0;
            if (km < 0)
            {
                return 0;
            }
            if (km <= 1)
            {
                price += 13000;
            }
            else if (km > 1 && km <= 30)
            {
                price = 13000 + (km - 1) * 12000;
            }
            else price = 13000 + 29 * 12000 + (km - 30) * 11000;
            return price;
        }
        public static void checkSnt()
        {
            Console.Write("Nhap vao mot so: ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            if (number < 2)
            {
                IsPrime = false;
            }
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.Write($"{number} la so nguyen to.");
            }
            else
            {
                Console.Write($"{number} khong phai so nguyen to.");
            }
        }
        public static void checkShh()
        {
            int a, sum = 0;
            Console.Write("\n Nhap vao so can kiem tra: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == a)
            {
                Console.WriteLine("\n {0} la so hoan hao.", a);
            }
            else
            {
                Console.WriteLine("\n {0} khong phai la so hoan hao.", a);
            }

        }
        public static void checkScp()
        {
            Console.Write("\n Nhap vao so can kiem tra: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //gọi hàm kiểm tra số chính phương để kiểm tra số vừa nhập
            if (soCP(n))
            {
                Console.WriteLine("\n So {0} la so chinh phuong.", n);
            }
            else
            {
                Console.WriteLine("\n So {0} khong phai la so chinh phuong.", n);
            }
        }

        static bool soCP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                return true;
            }
            else return false;
        }
        public static void shapeRect()
        {
            double a, b, P;
            Console.WriteLine("Nhap vao chieu dai a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());
            P = (a + b) * 2;
            Console.Write($"Chu vi hinh chu nhat la: {P}");
            Console.WriteLine("Dien tich: " + a * b);
        }
        public static void shapeSquare()
        {
            double a;
            Console.WriteLine("Nhap vao chieu dai 1 canh:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi: " + a * 4);
            Console.WriteLine("Dien tich: " + a * a);
        }
        public static void shapeOval()
        {
            const double pi = Math.PI;
            double a;
            Console.WriteLine("Nhap vao ban kinh:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Chu vi: " + 2 * a * pi);
            Console.WriteLine("Dien tich: " + a * a * pi);
        }
        public static void shapeTriangle()
        {
            double a, b, c;
            double S, C;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToDouble(Console.ReadLine());
            C = (a + b + c) / 2;
            Console.WriteLine($"Nua chu vi la: {C}");
            S = Math.Sqrt(C * (C - a) * (C - b) * (C - c));
            Console.WriteLine($"Dien tich la: {S}");
        }
        public static void sortArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int x = arr[i];
                        arr[i] = arr[j];
                        arr[j] = x;
                    }
                }
            }
        }

        //Loop
        // 1. 99
        // 2. 8
        // 3.
        // 4. 50
        public static double getS(int n, string caseText)
        {
            double S = 0;
            if (caseText == "a")
            {
                int s = 0;
                for (int i = 1; i <= n; i++)
                {
                    s += i;
                }
                S = s / n;
            }
            if (caseText == "b")
            {
                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    s += i * i;
                }
                S = Math.Sqrt(s);
            }
            if (caseText == "c")
            {
                S = Math.Sqrt(3);
                for (int i = 1; i < n; i++)
                {
                    S = Math.Sqrt(3 + S);
                }
            }
            if (caseText == "d")
            {
                S = 2;
                for (int i = 0; i < n; i++)
                {
                    S = 1 / (2 + 1 / S);
                }
            }
            return S;
        }

        public static void binaryDivide(int n)
        {
            string text = "";

            while (n != 0)
            {
                text = (n = n % 2).ToString();
            }
            Console.WriteLine(text);
        }

        public static void bai7()
        {
            for (int i = 10; i < 100; i++)
            {
                string number = i.ToString();
                char n1 = number.ToCharArray()[0];
                char n2 = number.ToCharArray()[1];

                int number1 = int.Parse(n1.ToString());
                int number2 = int.Parse(n2.ToString());
                if ((number1 * number2) % (number1 + number2) == 0 && (number1 * number2) / (number1 + number2) == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void checkShhLeftThan1000()
        {
            for (int i = 0; i < 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public static List<Int32> getListSNT(int range)
        {
            List<Int32> list = new List<Int32>();
            if (range < 2)
            {
                return list;
            }
            for (int i = 2; i < range; i++)
            {
                bool isP = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isP = false;
                        break;
                    }
                }
                if (isP)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static void checkNSNT()
        {
            Console.Write("Nhap vao so: ");
            int number = int.Parse(Console.ReadLine());
            List<Int32> list = getListSNT(number);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public static void getDoubleNumber()
        {
            List<Int32> list = getListSNT(1000);
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] + 2 == list[i + 1])
                {
                    Console.WriteLine(list[i] + " & " + list[i + 1]);
                }
            }
        }
        public static void countU()
        {
            Console.Write("Nhap vao so: ");
            int number = int.Parse(Console.ReadLine());
            int countNumber = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    countNumber++;
                }
            }
            Console.WriteLine(countNumber - 2);
        }
    }

}
