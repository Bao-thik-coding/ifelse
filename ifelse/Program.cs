using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số cần đọc: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 10 && number >= 0)
            {
                // Bước 2: Đọc số có một chữ số
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        Console.WriteLine("out of ability");
                        break;
                }
            }
            else if (number < 20 && number >= 10)
            {
                // Bước 3: Đọc số có hai chữ số nhỏ hơn 20
                int ones = number % 10;
                switch (number)
                {
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                    default:
                        Console.WriteLine("out of ability");
                        break;
                }
            }
            else if (number < 100 && number >= 20)
            {
                // Bước 4: Đọc số có hai chữ số lớn hơn hoặc bằng 20
                int tens = number / 10;
                int ones = number % 10;
                string tensString = "";
                string onesString = "";

                switch (tens)
                {
                    case 2:
                        tensString = "twenty";
                        break;
                    case 3:
                        tensString = "thirty";
                        break;
                    case 4:
                        tensString = "forty";
                        break;
                    case 5:
                        tensString = "fifty";
                        break;
                    case 6:
                        tensString = "sixty";
                        break;
                    case 7:
                        tensString = "seventy";
                        break;
                    case 8:
                        tensString = "eighty";
                        break;
                    case 9:
                        tensString = "ninety";
                        break;
                    default:
                        Console.WriteLine("out of ability");
                        break;
                }

                switch (ones)
                {
                    case 1:
                        onesString = "one";
                        break;
                    case 2:
                        onesString = "two";
                        break;
                    case 3:
                        onesString = "three";
                        break;
                    case 4:
                        onesString = "four";
                        break;
                    case 5:
                        onesString = "five";
                        break;
                    case 6:
                        onesString = "six";
                        break;
                    case 7:
                        onesString = "seven";
                        break;
                    case 8:
                        onesString = "eight";
                        break;
                    case 9:
                        onesString = "nine";
                        break;
                }

                if (ones == 0)
                    Console.WriteLine(tensString);
                else
                    Console.WriteLine(tensString + " " + onesString);
            }
            else
            {
                Console.WriteLine("out of ability");
            }
            Console.ReadKey();
        }
    }
}
