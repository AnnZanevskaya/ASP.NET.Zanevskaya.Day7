using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Library
{
    public class CustomQueue<T>
    {
        private T[] array;
        private int head;       
        private int tail;       
        private int size;       
        static T[] emptyArray = new T[0];
        public int Count { get { return size; } }

        public CustomQueue()
        {
            array = emptyArray;
        }
        public CustomQueue(int capacity) 
        {
            if (capacity < 0) throw new ArgumentException("capacity");
            array = new T[capacity];
            head = 0;
            tail = 0;
            size = 0;
        }
        public void Enqueue(T item)
        {
            if (size == array.Length)
            {
                int newcapacity = array.Length * 3;
                if (newcapacity < array.Length + 4)
                {
                    newcapacity = array.Length + 4;
                }
                T[] newQueue = new T[newcapacity];
                SetCapacity(newcapacity);
            }

            array[tail] = item;
            tail = (tail + 1) % array.Length;
            size++;
        }
        public T Dequeue()
        {
            if (size == 0) throw new ArgumentException("array is empty");
                
            T removed = array[head];
            array[head] = default(T);
            head = (head + 1) % array.Length;
            size--;
            return removed;
        }
        public T Peek()
        {
            if (size == 0) throw new ArgumentException("array is empty");
            return array[head];
        }
        public CustomQueueEnumerator GetEnumerator()
        {
            return new CustomQueueEnumerator(this);
        }

        public struct CustomQueueEnumerator
        {
            private CustomQueue<T> q;
            private int index;
            private T currentElement;

            public CustomQueueEnumerator(CustomQueue<T> q)
            {
                this.q = q;
                index = -1;
                currentElement = default(T);
            }
            public T Current {
                get {
                    if (index < 0) throw new ArgumentException();
                    return currentElement;
                }
            }
            
             public void Dispose()
            {
                index = -2;
                currentElement = default(T);
            }
            public bool MoveNext() {  
                if (index == -2) return false;
                index++;
                if (index == q.size) {
                    index = -2;
                    currentElement = default(T);
                    return false;
                }

                currentElement = q.GetElement(index);
                return true;
            }
            public void Reset()
            {
                index = -1;
                currentElement = default(T);
            }
        }
        private T GetElement(int i)
        {
            return array[(head + i) % array.Length];
        }
        private void SetCapacity(int capacity)
        {
            T[] newarray = new T[capacity];
            if (size > 0)
            {
                if (head < tail)
                {
                    Array.Copy(array, head, newarray, 0, size);
                }
                else
                {
                    Array.Copy(array, head, newarray, 0, array.Length - head);
                    Array.Copy(array, 0, newarray, array.Length - head, tail);
                }                  
            }
            array = newarray;
            head = 0;
            tail = (size == capacity) ? 0 : size;
        }

    }
}
