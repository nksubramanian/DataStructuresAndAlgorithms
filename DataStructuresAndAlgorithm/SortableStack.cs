using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class SortableStack
    {
        void InsertAtSortedStack(Stack<int> stack, int numberToInsert)
        {
            if(stack.Count == 0)
            {
                stack.Push(numberToInsert);
                return;
            }
            else
            {
                var topElement = stack.Peek();
                if(topElement >= numberToInsert)
                {
                    stack.Push(numberToInsert);
                }
                else
                {
                    var poppedElement = stack.Pop();
                    InsertAtSortedStack(stack, numberToInsert);
                    stack.Push(poppedElement);
                }
            }
        }

        void SortStack(Stack<int> stack)
        {
            if (stack.Count <= 1)
                return;
            else
            {
                var poppedElement = stack.Pop();
                SortStack(stack);
                InsertAtSortedStack(stack, poppedElement);
                return;
            }
        }

        void printMyStack(Stack<int> stack)
        {
            int elementCount = stack.Count;
            for(int i = 0; i < elementCount; i++ )
            {
                var element = stack.Pop();
                Console.WriteLine(element);
            }
        }
        public void main()
        {
            Stack<int> intStack = new Stack<int>();
            intStack.Push(33);
            intStack.Push(12);
            intStack.Push(51);
            intStack.Push(60);
            SortStack(intStack);
            printMyStack(intStack);
        }
    }
}
