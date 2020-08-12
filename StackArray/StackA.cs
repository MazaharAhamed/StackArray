using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace StackArray
{
    class StackA
    {
        private int[] StackArray;
        private int top;

        public StackA()
        {
            StackArray = new int[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            StackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool isEmpty()
        {
            return (top == -1);
        }

        public bool isFull()
        {
            return (top == StackArray.Length - 1);
        }

        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Overflow");
            }
            top = top + 1;
            StackArray[top] = x;
        }

        public int Pop()
        {
            int x;
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            x = StackArray[top];
            top = top - 1;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Stack Underflow");
            return StackArray[top];
        }

        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Stack is:");
            for(int i=top;i>=0;i--)
            {
                Console.WriteLine(StackArray[i]+ " ");
                Console.WriteLine("");
            }
        }
    }
}
