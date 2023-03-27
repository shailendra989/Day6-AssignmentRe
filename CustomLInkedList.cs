using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListA
{
    public class CustomLInkedList<T>
    {
        public Node<T> head;

        public void AddLast(T data)
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
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                 temp.next = newNode;
                 Console.WriteLine(newNode.data);
            }

         }

            public void AddFirst(T data)
            {
            Node<T> newNode = new Node<T>(data);
            Console.WriteLine("inserted into - "+newNode.data);
            newNode.next = head;
            head = newNode;

            }
            public void Display()
            {
              if(head == null)
              {
                Console.WriteLine("Linked list is empty ");

              }
              else
              {
                Node<T> temp = head;
                while(temp != null) {

                    
                     Console.WriteLine(temp.data);
                     temp = temp.next;

                
                }

              }

            }
            
            public Node<T> RemovalFirstNode()
            {
              if(this.head == null)
            
                return  null ;
              this.head = this.head.next;
             return this.head ;
            

            }

            public void Search(T value)
             {

            Node<T> temp = this.head ;
            while(temp != null)
            {
                if(EqualityComparer<T>.Default.Equals(temp.data, value)) {
                    Console.WriteLine("Given vale : " +value+  " +is present ");
                    return;
              
                
                }
                temp = temp.next;
            }
              if(temp == null)
            {
                Console.WriteLine(value+" given value is not present in linked list");
            }

             }
    }
}