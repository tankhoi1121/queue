using System;

namespace QueueAIO
{
    class Program
    {
        static void PrintQueue(int[] queue, int max)
        {
            for (var i = 0; i < max; i++)
            {
                Console.WriteLine($"{queue[i]}; ");
            }
        }
        static void Main(string[] args)
        {
            int[] queue = new int[10];
            int max = queue.Length;

            int rear = 0;
            int front = 0;

            QueueBehavior queueBehavior = new QueueBehavior();

            queueBehavior.enqueue(queue, max, ref rear, ref front, 44);
            queueBehavior.enqueue(queue, max, ref rear, ref front, 21);
            queueBehavior.enqueue(queue, max, ref rear, ref front, 26);
            queueBehavior.enqueue(queue, max, ref rear, ref front, 33);
            queueBehavior.enqueue(queue, max, ref rear, ref front, 13);
            queueBehavior.enqueue(queue, max, ref rear, ref front, 4);

            //PrintQueue(queue, max);
            Console.WriteLine(queueBehavior.dequeue(queue, max, ref rear, ref front));

            Console.ReadKey();
        }
    }
}
