using System;
using System.Collections.Generic;

namespace HW3_list_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Время вставки O(1)
            //Время удаление с середины O(1)
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.Push(1);
            linkedList.Push(2);
            linkedList.Push(3);
            linkedList.AddFirst(4);
            linkedList.RemoveFirst();



            foreach (int l in linkedList)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine(linkedList.Contains(1));
            Console.WriteLine(linkedList.IsEmpty());
            Console.WriteLine(linkedList.Peek());
            linkedList.Clear();
            Console.WriteLine(linkedList.IsEmpty());


            //Время вставки O(1)
            //Время удаление с середины O(n)
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list[2]);
            list.Insert(3, 10);
            Console.WriteLine(list[3]); 
            Console.WriteLine(list.IsEmpty());
            foreach (int l in list)
            {
                Console.WriteLine(l);
            }
            list.Clear();
            Console.WriteLine(list.IsEmpty());

          








        }
    }
}
