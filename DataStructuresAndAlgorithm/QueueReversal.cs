using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    internal class QueueReversal
    {
        void printMyQueue(Queue<int> queue)
        {
            var count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        void reverseMyQueue(Queue<int> queue)
        {
            if (queue.Count <= 1)
            {
                return;
            }
            else
            {
                var element = queue.Dequeue();
                reverseMyQueue(queue);
                queue.Enqueue(element);
            }
        }

        public void main()
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            reverseMyQueue(myQueue);
            printMyQueue(myQueue);
        }

    }
}
