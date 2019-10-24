using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STACK
{
   public class Stack
    {
       private int top;
       private string[] buffer;
       public Stack(int size)
       {
           buffer = new string[size];
           top = -1;
       }
       /// <summary>
       /// initilize
       /// </summary>
       public Stack()
       {
           buffer = new string[1000];
           top = -1;
       }
       public void Push(string value)
       {
           buffer[top + 1] = value;
           top++;
       }
       public string Pop()
       {
          string value = buffer[top];
          top--;
          return value;
       }
       public string Peek()
       {
          string value = buffer[top];
          return value;
       }
       public int Count()
       {
           return top + 1;
       }
       public void Clear()
       {
             top = -1;
       }

    }
}
