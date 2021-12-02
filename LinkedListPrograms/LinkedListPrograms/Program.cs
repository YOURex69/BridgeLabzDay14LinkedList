using System;

namespace LinkedListPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            ListFunctions obj = new ListFunctions();
            obj.Add(56);
            obj.Add(30);
            obj.Add(70);
           

            obj.display();

            Console.WriteLine("------delete first---------");

            obj.deleteFirst();
            obj.display();
            Console.WriteLine("-------delete last--------");

            obj.deleteLast();
            obj.display();
            Console.WriteLine("------delete---------");
            obj.Add(10);
            obj.Add(90);
            obj.Add(25);
            obj.Add(999);

            obj.delete(90);
            obj.display();

        }
    }
}
