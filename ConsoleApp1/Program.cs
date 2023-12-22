using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            Console.WriteLine("1 ededi daxil edin: ");
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            Console.WriteLine("2 ededi daxil edin :");
            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            Console.WriteLine("3 ededini daxil edin ");
            string num3Str = Console.ReadLine();
            int num3 = Convert.ToInt32(num3Str);

            int biggest;
            if (num1 > num2)
            {
                if (num1 > num3)
                    biggest = num1;
                else
                    biggest = num3;
            }
            else if (num2 > num3)
                biggest = num2;
            else biggest = num3;
            Console.WriteLine($"en boyuk eded :{biggest}");

                
        




           //Verilmiş yazının içində  verilmis hərfinin olub olmadığını tapan proqram
            Console.WriteLine("Bir yazi daxil edin ");
            string text = Console.ReadLine();
            Console.WriteLine("axtarilan herfi  daxil edin");
            string letterStr = Console.ReadLine();
            char letter = Convert.ToChar(letterStr);
            bool hasA = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]== letter)
                {
                    hasA = true;
                    break;

                }
            }
            if (hasA ) Console.WriteLine($"{letter} herifi var");
            else Console.WriteLine($"{letter} herifi var");


            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

            Console.WriteLine("bir yazi daxil edin :");
            string text1 = Console.ReadLine();
            int aCount = 0;


            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] == 'A')
                {
                    aCount++;
                }
            }

            Console.WriteLine($"yazida {aCount} sayda 'A' herifi var ");



            //Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir


            Console.WriteLine("bir ededi daxil edin ");
            int eded;
            do
            {
                eded = Convert.ToInt32(Console.ReadLine());

            } while (eded <= 0 || eded % 2 != 0);
            int p = eded * eded;
            Console.WriteLine("ededin kvadrati:" + p);




            //Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan proqram

            Console.WriteLine("Ededlerin sayini daxil edin:");
            string numsCountStr = Console.ReadLine();
            int numsCount = Convert.ToInt32(numsCountStr);

            int[] nums = new int[numsCount];

            string output = "";
            for (int i = 0; i < nums.Length; i++)
            {
               Console.WriteLine($"{i+1}. ededi yaz");
               string numStr = Console.ReadLine();
               int num = Convert.ToInt32(numStr);
               nums[i] = num;


                if(i!=0 && num >=0)
                   output += "+";
               output += numStr;
            }

            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               sum=sum+nums[i];
            }

            output += $"={sum}";
            Console.WriteLine(output);


            //Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            //Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat.
            //heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.
            // tehsil novu yanlisdirsa yenide daxil edin 

            bool checkInput;
            do
            {
                Console.WriteLine("Tehsil novunu daxil edin:");
                string educationType = Console.ReadLine();
                checkInput = true;

                switch (educationType)
                {
                    case "programming":
                        Console.WriteLine("400 saat");
                        break;
                    case "design":
                        Console.WriteLine("250 saat");
                        break;
                    case "system":
                        Console.WriteLine("200 saat");
                        break;
                    default:
                        checkInput = false;
                        Console.WriteLine("Tehsil novu yanlisdir");
                        break;
                }
            } while (!checkInput);









        }
    }
}
