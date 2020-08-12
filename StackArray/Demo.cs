using StackArray;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackArrayProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;

            StackA st = new StackA(8);

            while(true)
            {
                Console.WriteLine("1.Push an element to the Stack");
                Console.WriteLine("2.Pop an element from the Stack");
                Console.WriteLine("3.Display the top element");
                Console.WriteLine("4.Display all elements");
                Console.WriteLine("5.Display the size of the stack");
                Console.WriteLine("6.Quit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element to be inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        st.Push(x);
                        break;
                    case 2:
                        x = st.Pop();
                        Console.WriteLine("Popped element is: "+x);
                        break;
                    case 3:
                        Console.WriteLine("The top element is: " + st.Peek());
                        break;
                    case 4:
                        st.Display();
                        break;
                    case 5:
                        Console.WriteLine("The size of the stack is:" + st.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
