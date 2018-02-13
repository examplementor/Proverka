using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
        Повтор:
            Console.WriteLine("Hомер задания");
            int v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    nomer1();
                    break;
                case 2:
                    nomer2();
                    break;
                case 3:
                    nomer3();
                    break;
                case 4:
                    nomer4();
                    break;
                case 5:
                    nomer5();
                    break;
                case 6:
                    nomer6();
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("В начало проги?");
            int vibor1 = Convert.ToInt32(Console.ReadLine());
            if (vibor1 == 1)
            {
                goto Повтор;
            }
            Console.ReadKey();
        }
        public static void nomer1()
        {
            List<string> strings = new List<string>() { "sdfsdfkjорпорпорпывпвыпваdfgdfgdfhfdghfvbfh" };
            foreach (string item in strings)
            {
                Console.WriteLine("Исходная строка");
                Console.WriteLine(item);
                List<char> chars = new List<char>(item.ToCharArray());
                chars.Sort();
                string outString = new string(chars.ToArray());
                Console.WriteLine("Конечная строка");
                Console.WriteLine(outString);
            }
            Console.ReadKey();
            
        }
        public static void nomer2()
        {
            string str = "равенство";
            Console.WriteLine("Исходное слово: ");
            Console.Write(str);
            Console.WriteLine();
            Console.WriteLine("Конечное слово: ");
            char[] arrChar = new char[str.Length];
            for (int i = 0; i < str.Length; ++i)
                arrChar[i] = str[i];
            Console.Write(arrChar[4].ToString() +
                arrChar[3].ToString() +
                arrChar[0].ToString() +
                arrChar[1].ToString() +
                arrChar[2].ToString() +
                arrChar[3].ToString() +
                arrChar[4].ToString() +
                arrChar[5].ToString() +
                arrChar[6].ToString() +
                arrChar[7].ToString() +
                arrChar[8].ToString());
            Console.ReadKey();

        }
        public static void nomer3()
        {
            string str = Console.ReadLine();
            str = str.Replace("                           ", " ");
            str = str.Replace("                          ", " ");
            str = str.Replace("                         ", " ");
            str = str.Replace("                        ", " ");
            str = str.Replace("                       ", " ");
            str = str.Replace("                      ", " ");
            str = str.Replace("                     ", " ");
            str = str.Replace("                    ", " ");
            str = str.Replace("                   ", " ");
            str = str.Replace("                  ", " ");
            str = str.Replace("                 ", " ");
            str = str.Replace("                ", " ");
            str = str.Replace("               ", " ");
            str = str.Replace("              ", " ");
            str = str.Replace("             ", " ");
            str = str.Replace("            ", " ");
            str = str.Replace("           ", " ");
            str = str.Replace("          ", " ");
            str = str.Replace("         ", " ");
            str = str.Replace("        ", " ");
            str = str.Replace("       ", " ");
            str = str.Replace("      ", " ");
            str = str.Replace("    ", " ");
            str = str.Replace("   ", " ");
            str = str.Replace("  ", " ");
            Console.WriteLine(str);



        }
        public static void nomer4()
        {
            Console.Write("Введите строку: ");
            String s = Console.ReadLine();
            String[] arr = s.Split(new char[] { '#', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов: {0}", arr.Length);
            Console.Write("Cлова: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                Console.Write(arr[i] + " ");
            }
            string[] mas = s.Split('#');
            int min = mas[0].Length;
            int max = mas[0].Length;
            string ms = mas[0];
            int indexer = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i].Length < min)
                {
                    min = mas[i].Length;
                    ms = mas[i];
                    indexer = i;
                }
            }
            Console.WriteLine("\nСловo с минимальной длиной {0} и его местоположение = {1}", ms, indexer + 1);
            string s1 = "a";
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s1[0] == s[i]) { j++; }
            }
            Console.WriteLine("Кол-во вхождений 'а' в строку = "+j);

        }
        public static void nomer5()
        {
            Console.WriteLine("Введите число:");
            int num = Int32.Parse(Console.ReadLine());
            int sum = Sum(num);
            Vivod(sum, "sum");
        }
        static int Sum(int number)
        {
            int sum = 0;

            if (number >= 0)
            {
                char[] numbers = number.ToString().ToCharArray();
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += Int32.Parse(numbers[i].ToString());
                }
            }

            return sum;
        }
        static void Vivod(int value, string text = null)
        {
            Console.WriteLine("{0} = {1}", text, value);
        }
        public static void nomer6()
        {
            Console.Write("Введите строку: ");
            String ss = Console.ReadLine();
            StringBuilder s = new StringBuilder(ss);
            string s1 = "a";
            string s2 = "б";
            string s3 = "в";
            string s4 = "г";
            string s5 = "д";
            string s6 = "е";
            string s7 = "ё";
            string s8 = "ж";
            string s9 = "з";
            string s10 = "и";
            string s11 = "й";
            string s12 = "к";
            string s13 = "л";
            string s14 = "м";
            string s15 = "н";
            string s16 = "о";
            string s17 = "п";
            string s18 = "р";
            string s19 = "с";
            string s20 = "т";
            string s21 = "у";
            string s22 = "ф";
            string s23 = "х";
            string s24 = "ц";
            string s25 = "ч";
            string s26 = "ш";
            string s27 = "щ";
            string s28 = "ъ";
            string s29 = "ы";
            string s30 = "ь";
            string s31 = "э";
            string s32 = "ю";
            string s33 = "я";

                for (int i = 0; i < s.Length; i++)
                {
                    if (s1[0] == ss[i]) { s[i] = s33[0]; }
                    if (s2[0] == ss[i]) { s[i] = s32[0]; }
                    if (s3[0] == ss[i]) { s[i] = s30[0]; }
                    if (s4[0] == ss[i]) { s[i] = s31[0]; }
                    if (s5[0] == ss[i]) { s[i] = s29[0]; }
                    if (s6[0] == ss[i]) { s[i] = s27[0]; }
                    if (s7[0] == ss[i]) { s[i] = s28[0]; }
                    if (s8[0] == ss[i]) { s[i] = s25[0]; }
                    if (s9[0] == ss[i]) { s[i] = s26[0]; }
                    if (s10[0] == ss[i]) { s[i] = s24[0]; }
                    if (s11[0] == ss[i]) { s[i] = s23[0]; }
                    if (s12[0] == ss[i]) { s[i] = s21[0]; }
                    if (s13[0] == ss[i]) { s[i] = s22[0]; }
                    if (s14[0] == ss[i]) { s[i] = s10[0]; }
                    if (s15[0] == ss[i]) { s[i] = s16[0]; }
                    if (s16[0] == ss[i]) { s[i] = s17[0]; }
                    if (s17[0] == ss[i]) { s[i] = s18[0]; }
                    if (s18[0] == ss[i]) { s[i] = s19[0]; }
                    if (s19[0] == ss[i]) { s[i] = s20[0]; }
                    if (s20[0] == ss[i]) { s[i] = s11[0]; }
                    if (s21[0] == ss[i]) { s[i] = s12[0]; }
                    if (s22[0] == ss[i]) { s[i] = s13[0]; }
                    if (s23[0] == ss[i]) { s[i] = s14[0]; }
                    if (s24[0] == ss[i]) { s[i] = s15[0]; }
                    if (s25[0] == ss[i]) { s[i] = s7[0]; }
                    if (s26[0] == ss[i]) { s[i] = s8[0]; }
                    if (s27[0] == ss[i]) { s[i] = s9[0]; }
                    if (s28[0] == ss[i]) { s[i] = s5[0]; }
                    if (s29[0] == ss[i]) { s[i] = s6[0]; }
                    if (s30[0] == ss[i]) { s[i] = s1[0]; }
                    if (s31[0] == ss[i]) { s[i] = s4[0]; }
                    if (s32[0] == ss[i]) { s[i] = s2[0]; }
                    if (s33[0] == ss[i]) { s[i] = s3[0]; }
                }
                Console.WriteLine(s);
            
        }
    }
}