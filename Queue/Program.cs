using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            foreach (var item in ReverseQueue(q))
            {
                Console.WriteLine(item);
            }

        }
        public static Queue<int> ReverseQueue(Queue<int> q)
        {
            int count = q.Count;
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                s.Push(q.Dequeue());
            }
            for (int i = 0; i < count; i++)
            {
                q.Enqueue(s.Pop());
            }
            return q;
        }
    }

}
