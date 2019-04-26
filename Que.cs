using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Que<T>
    {
        Node<T> first;
        Node<T> last;
        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (first == null)
            {
                last = newNode;
                first = last;
            }
            else
            {
                last.next = newNode;
                last = last.next;
            }
        }

        public bool IsEmpty()
        {
            return first == null;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException();

            T value = first.value;

            first = first.next;

            return value;
        }
    }
}
