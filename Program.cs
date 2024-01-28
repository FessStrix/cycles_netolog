using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycles_netolog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            int[] array = new int[10] { 0, 1, 1, 2, 3, 5, 8, 13,21,34 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                    
                    }
            //Задание 2

            for (int x = 2;x<=20 ; x+=2) 
             { 
             Console.WriteLine(x);
            }
            //Задание 3

            for (int x = 1;x<=5;x++ )
              for (int y = 1;y<=10 ; y++ ) 
                
                { 
                
                Console.WriteLine($"{x} умножить на {y} = {x*y}");
                }
            //Задание 4

            string password = "qwerty";
            do { password = Console.ReadLine();
            
            }
            
            while (password != "qwerty");
            Console.ReadKey();












        }
    }
}
