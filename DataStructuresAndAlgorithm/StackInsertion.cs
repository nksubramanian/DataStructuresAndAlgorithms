using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class StackInsertion
    {

        void InsertAtBottom(Stack<int> stack, int elementToAdd)
        {
            if(stack.Count==0)
                stack.Push(elementToAdd);
            else
            {
                var poppedElement = stack.Pop();
                InsertAtBottom(stack, elementToAdd);
                stack.Push(poppedElement);
            }
        }


        void reverseMyStack(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;
            else
            {
                var poppedElement = stack.Pop();
                reverseMyStack(stack);
                InsertAtBottom(stack, poppedElement);
            }
        }


        void printMyStack(Stack<int> stack)
        {
            var stackCount = stack.Count;
            for(int i = 0; i < stackCount; i++)
            {
                var poppedElement = stack.Pop();
                Console.WriteLine(poppedElement);
            }
        }


        public void main()
        {
            var stack = new Stack<int>();
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);
            reverseMyStack(stack);
            printMyStack(stack);    


        }

    }
}
