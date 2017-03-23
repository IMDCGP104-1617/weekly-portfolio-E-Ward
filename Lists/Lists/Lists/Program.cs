using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            while (!stack.IsEmpty())

            {
                int output;
                stack.Pop(out output);
                Console.WriteLine(output);
            }*/

            Queue<string> Queue = new Queue<string>();
            Queue.EnQueue("Kill");
            Queue.EnQueue("me");
            Queue.EnQueue("please");
            Queue.EnQueue("1");
            Queue.EnQueue("2");
            Queue.EnQueue("3");
            Queue.EnQueue("4");
            Queue.EnQueue("5");

            while (!Queue.IsEmpty())

            {
                string output;
                Queue.DeQueue(out output);
                Console.WriteLine(output);
            }


            Console.Read();
        }
    }
}
