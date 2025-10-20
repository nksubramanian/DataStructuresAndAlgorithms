// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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


Queue<int> myQueue = new Queue<int>();
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
reverseMyQueue(myQueue);
printMyQueue(myQueue);

