using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1111410054_謝采翔032
{
    internal class Program
    {
        static string IntToRoman(int number) //依照題目所給的羅馬數字對應數字來轉換
        {
            if (number >= 1000) return "M" + IntToRoman(number - 1000);
            if (number >= 900) return "CM" + IntToRoman(number - 900);
            if (number >= 500) return "D"  + IntToRoman(number - 500);
            if (number >= 400) return "CD" + IntToRoman(number - 400);
            if (number >= 100) return "C"  + IntToRoman(number - 100);
            if (number >= 90) return "XC"  + IntToRoman(number - 90);
            if (number >= 50) return "L"   + IntToRoman(number - 50);
            if (number >= 40) return "XL"  + IntToRoman(number - 40);
            if (number >= 10) return "X"   + IntToRoman(number - 10);
            if (number >= 9) return "IX"   + IntToRoman(number - 9);
            if (number >= 5) return "V"    + IntToRoman(number - 5);
            if (number >= 4) return "IV"   + IntToRoman(number - 4);
            if (number >= 1) return "I"    + IntToRoman(number - 1);
            return "";
        }

        static void Main(string[] args)
        {
            int number = 0;
            bool Input = false;

            while (!Input)  //重複執行直到輸入正確為止
            {
                Console.WriteLine("請輸入一個整數: ");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (1 <= number && number <= 3999)
                    {
                        Input = true;                // 讓程式在這裡印出結果後就結束        
                        Console.WriteLine($"轉換成的羅馬數字為: {IntToRoman(number)}");
                    }
                    else
                    {
                        Console.WriteLine("輸入的數字不在有效範圍內 (1~3999)");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("輸入的不是有效的(整數)，請再重新輸入。");
                }
            }
            Console.Read();
        }
    }
}
