using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListA
{
    public  class CustomQueue<T>
    {
       
            public Node<T> head;
            public void Enque(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                    Console.WriteLine(newNode.data);

                }
                else
                {
                    Node<T> temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                    Console.WriteLine(newNode.data);
                }

            }


            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("Linked list is empty ");

                }
                else
                {
                    Node<T> temp = head;
                    while (temp != null)
                    {


                        Console.WriteLine(temp.data);
                        temp = temp.next;


                    }
                }
            }

            public Node<T> Deque()
            {
                if (head == null)
                    return null;
                if (head.next == null)
                    return null;
                Node<T> newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                return head;
            }

          




        


    }
}
