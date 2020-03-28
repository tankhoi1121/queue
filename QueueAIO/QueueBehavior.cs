using System;
using System.Collections.Generic;
using System.Text;

namespace QueueAIO
{
    public class QueueBehavior
    {
        #region -- Status --
        private bool isFull(int max, ref int rear)
        {
            if (rear + 1 == max)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private bool isEmpty(int max, ref int rear, ref int front)
        {
            if (front == -1 || front > rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region -- Operator --
        public void enqueue(int[] queue, int max, ref int rear, ref int front, int values)
        {
            if (isFull(max, ref rear))
            {
                Console.WriteLine("Overflow");
            }
            else
            {

                queue[rear] = values;
                rear++;
            }
        }

        public int dequeue(int[] queue, int max, ref int rear, ref int front)
        {
            int data = 0;
            if (isEmpty(max, ref rear, ref front))
            {
                Console.WriteLine("Underflow");
            }
            else
            {
                data = queue[front];
                front++;
            }
            return data;
        }
        #endregion
    }
}
