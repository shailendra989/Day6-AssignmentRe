using System.ComponentModel;

namespace LinkedListA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding Node in the linked List");
            /*
            CustomLInkedList<int> linkedlist = new CustomLInkedList<int>();
            linkedlist.AddFirst(70);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(56);

            linkedlist.Display();
            linkedlist.RemovalFirstNode();
            linkedlist.Search(30);
            linkedlist.Display();

            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(30);
            stack.Push(56);
            stack.Push(70);
            stack.Push(90);
             
            stack.Pop();

            CustomQueue<int>Queue = new CustomQueue<int>();
            Queue.Enque(56);
            Queue.Enque(30);
            Queue.Enque(90);
            Queue.Deque();
            */


            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(70);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(56);

            linkedlist.RemoveFirst();
            linkedlist.Find(30);
            foreach (int i in linkedlist)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(30);
            stack.Push(56);
            stack.Push(70);
            stack.Push(90);

            stack.Pop();
            foreach (int i in linkedlist)
            {
                Console.WriteLine(i);
            }

            Queue<int> Queue = new Queue<int>();
            Queue.Enqueue(56);
            Queue.Enqueue(30);
            Queue.Enqueue(90);
            Queue.Dequeue();
            foreach (int i in linkedlist)
            {
                Console.WriteLine(i);
            }



        }
    }
}