using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AnyDataTypeQueue
    {
        public Queue? Queue {  get; set; }

        public AnyDataTypeQueue() 
        {
           Queue = new Queue();
        }

        public void Enqueue(object x)
        {
            Queue?.Enqueue(x);
        }

        public object Dequeue()
        {
            if (Queue is null || Queue.Count == 0)
            {

                throw new InvalidOperationException("Queue is empty.");

            }

            return Queue?.Dequeue() ?? " ";
        }

        public object Peek()
        {
            if (Queue is null || Queue.Count == 0)
            {

                throw new InvalidOperationException("Queue is empty.");

            }

            return Queue?.Peek() ?? " ";
        }

        public int Count()
        {
            return Queue?.Count ?? 0;
        }

        public void Print()
        {
            foreach (var item in Queue)
                Console.Write($"{item} ");
        }
    }
}
