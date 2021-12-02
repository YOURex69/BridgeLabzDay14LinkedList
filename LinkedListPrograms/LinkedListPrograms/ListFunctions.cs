using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListPrograms
{
    public class ListFunctions
    {
        public Node head;
        public void Add(int number)
        {
            Node newNode = new Node(number);
            if(head==null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;

                
            }
            Console.WriteLine(number + " Data Entered");
        }
       
        public void deleteFirst()
        {
            if(this.head==null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            {
                Node temp=head;
                head = head.next;
                temp.next = null;
                Console.WriteLine("Value  delete from first");
            }

        }
        public void deleteLast()
        {
            if(head==null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            { 
                Node temp = head;
                while(temp.next.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Value Deleted from last");
            }
        }
        public void delete(int number)
        {
            Node temp = head;
            while(temp.next!=null && temp.next.data!=number)
            {
                    temp = temp.next;
            }
            Node nxt = temp.next;
            temp.next = nxt.next;
            nxt.next = null;


        }
        public bool search(int number)
        {
            Node temp = head;
            while(temp.next!=null)
            {
                if(temp.data==number)
                {
                    return true;
                }
                temp = temp.next;
            }


            return false;

        }
        
        public void display()
        {
            if(head==null)
            {
                Console.WriteLine("Nothing to diaplsy");
            }
            else
            {
                Node temp = head;
                while(temp!=null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }


    }
}
