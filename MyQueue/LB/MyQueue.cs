using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB
{
    public class Node<T>
    {
        public Node(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
    
    public class MyQueue<T> : IEnumerable<T>
    {
        Node<T> head; 
        Node<T> tail; 
        int count;
        
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public MyQueue<string> Solution(MyQueue<string> queue, string element)
        {
            MyQueue<string> q2 = new MyQueue<string>();

            int k = 0;

            foreach (string el in queue)
            {
                q2.Enqueue(el);
                if (Convert.ToInt32(el) % 2 == 0)
                    q2.Enqueue(element);
                k++;
            }

            return q2;
        }
    }
}
