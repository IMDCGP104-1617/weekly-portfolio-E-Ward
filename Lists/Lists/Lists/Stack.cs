using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Stack<T>
    {
        private List<T> stack;
        private int count; //Shows the size of the stack

        public int Count { get { return count; } }

        public Stack()
        {
            stack = new List<T>();
        }

        ~Stack() //Deconstructor
        {
            while (!IsEmpty()) //While it is not empty remove the top until it is empty
            {
                T output; //Output of value T
                Pop(out output);
            }
        }

        public void Push(T data)
        {
            count++;
            stack.InsertBeginning(data);
        }

        public bool Pop(out T output)
        {
            output = default(T);
            if (IsEmpty())
            {
                return false;
            }
            output = stack.RemoveBeginning(); //Removes the top item from the stack
            count--; //Takes one from the size of the stack
            return true;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek() //Allows us to look at the top value of the stack without touching it
        {
            return stack.Head; //Returns the data that is contained in the head 
        }

    }
}
