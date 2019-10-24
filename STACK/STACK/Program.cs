using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Pham", "Ngoc", "Duy" };
            Stack S = new Stack();
            for (int j = 0; j < array.Length; j++)
                Console.Write(array[j] + " ");
            S.Pop(array[0]);



                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
     
        }
    }
}
