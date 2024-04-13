using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1111410054_謝采翔031
{
    internal class Program
    {       
        static  IList<int> FindWords(string[] words, char x)
        {
             var list = new List<int>();
             for (var i = 0; i < words.Length; i++)
             {
                if (!string.IsNullOrEmpty(words[i]) && words[i].Contains(x)) //檢查字串是否有效以及有沒有包含字元x
                    list.Add(i);
             }
             return list ;
        }        
        static void Main(string[] args)

        {
            string[] words = new string[50];
            for(int i = 0; i < words.Length; i++)    // 讓使用者輸入字串時，知道輸入到第幾個
            {
                Console.WriteLine($"請輸入第 {i + 1} 個字串：");
                words[i] = Console.ReadLine().ToLower();              
                if (string.IsNullOrEmpty(words[i])) // 當輸入為空值時，跳出迴圈
                {
                    break;
                }
            }            

            Console.WriteLine("請輸入一個字元: ");
            char x = Convert.ToChar(Console.ReadLine().ToLower()[0]);   
            int[] indices = FindWords(words,x).ToArray();
            Console.WriteLine("輸入字元出現位置： ");            
            Console.Write("[");
            foreach (int idx in indices)
            {
                Console.Write($"{idx}");
                if (idx < indices.Length - 1) //為了像題目給的輸出一樣才寫的，用","區隔索引
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]"); 
            Console.Read();
        }   
    }
}
