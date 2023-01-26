using System;

namespace DS
{
    class Stack<T>
    {
        T[] stack;
        int Size = 0;
        int Capacity;
        public Stack (int capacity)
        {
            stack = new T[capacity];
            this.Capacity = capacity;
        }
        public void push(T a)
        {
            if (Size>=Capacity)
                throw new Exception("Stack is full!");
            stack[Size] = a;
            Size ++;
        }
        public T pop()
        {
            if (Size==0)
                throw new Exception("Stack is empty!");
            Size --;
            return(stack[Size]);
        }
        public T top()
        {
            if (Size==0)
                throw new Exception("Stack is empty!");
            return(stack[Size-1]);
        }
        public int size() => Size;
        public int capacity() => Capacity;
    }

    class program
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>(5);
            stack.push("!");
            stack.push("word");
            stack.push(" ");
            stack.push("Hello");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(stack.pop());
            }
        }
    }
}
