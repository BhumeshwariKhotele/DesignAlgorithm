using System;
using System.Collections.Generic;
using System.Text;

namespace QueueSample
{
    public class Queues<T>
    {
        List<T> contents = new List<T>();

        //constructor
        public Queues()
        {

        }

        //gets the number of items in queue
        public int Count
        {
            get { return contents.Count; }
        }

        //enqueue method (pushes the item on the queue)
        public void Enqueue(T item)
        {
            contents.Add(item);
        }

        //Dequeue method (removes the item from the queue)
        public T Dequeue()
        {
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't pop from the queue");
            }
            else
            {
                //retrieve top of queue, remove and return

                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }

        
    }


}
