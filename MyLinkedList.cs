using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW3_list_
{
    class MyLinkedList<TItem> : IEnumerable<TItem>
    {
        Node<TItem> head;
        Node<TItem> tail;
        int count=0;



        private class Node<TItem>
        {
            public TItem value;
            public Node<TItem> prev;
            public Node<TItem> next;
            public Node(TItem value)
            {
                this.value = value;
            }
        }

        public void Push(TItem value)
        {
            Node<TItem> node = new Node<TItem>(value);
            if (head == null)
                head = node;
            else
            {
                tail.next = node;
                node.prev = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(TItem value)
        {
            Node<TItem> node = new Node<TItem>(value);
            Node<TItem> temp = head;
            node.next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.prev = node;
            count++;
        }

        public bool Contains(TItem value)
        {
            Node<TItem> current = head;
            while (current != null)
            {
                if (current.value.Equals(value))
                    return true;
                current = current.next;
            }
            return false;
        }
        public void Remove(TItem value)
        {
            Node<TItem> current = head;

        
            while (current != null)
            {
                if (current.value.Equals(value))
                {
                    break;
                }
                current = current.next;
            }
            if (current != null)
            {
                
                if (current.next != null)
                {
                    current.next.prev = current.prev;
                }
                else
                {
                   
                    tail = current.prev;
                }

                
                if (current.prev != null)
                {
                    current.prev.next = current.next;
                }
                else
                {
                   
                    head = current.next;
                }
                count--;

            }
        }
        public void RemoveFirst()
        {

            head = head.next;
            

        }
       

        public bool IsEmpty()
        {
            if (count > 0)
            {
                return false;
            }
            else return true;
        }
        public TItem Peek()
        {
           
                return tail.value;
            
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            Node<TItem> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.next;    
          }
        }
        public IEnumerator<TItem> BackEnumerator()
        {
            Node<TItem> current = tail;
            while (current != null)
            {
                yield return current.value;
                current = current.prev;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
