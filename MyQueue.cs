using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    internal class MyQueueCls<T>
    {
        private int head;
        private int tail;
        private int count;
        private T[] q;
        private int deFaultQueSize=50;

        public MyQueueCls()
        {
            q= new T[deFaultQueSize];
            count=0;
            head=0;
            tail=0;
        }

        public MyQueueCls(int size)
        {
            if (size > 0)
            {
                deFaultQueSize = size;
                q = new T[deFaultQueSize];
                count = 0;
                head=0;
                tail=0;
            }
            else
            {
                throw new Exception("Size cannot be equal or smaller than zero");
            }     
            
        }

        public void Enqueue(T num) 
        {
            if(count >= deFaultQueSize) 
            {
                throw new Exception("Queue is full");
            }
            else
            {
                q[head] = num;
                count++;
                head++;
                head%= deFaultQueSize;
            }
        }

        public T Dequeue()
        {
            if(count<=0)
            {
                throw new Exception("Queue is already empty");
            }
            else
            {
                T rValue= q[tail];
                tail++;
                tail%= deFaultQueSize;
                count--;
                return rValue;
            }
        }

    }
}
