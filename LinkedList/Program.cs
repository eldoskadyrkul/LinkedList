using System;

namespace LinkedList
{
    class Program
    {
        static LinkedList list = new LinkedList();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, guest");
            Console.WriteLine("1. Add an item to the list at specified index");
            addList(list);
            Console.WriteLine("2. Add an item to the END of the list");
            addListByIndex(list);
            Console.WriteLine("3. Remove the item in the list at the specified index");
            var t = Console.ReadLine();
            list.Delete(int.Parse(t));
            Console.WriteLine("Size of list: " + list.Count);
            Console.WriteLine("4. Get the index of the item in the list");
            Console.WriteLine("You enter an index for get item");
            var v = Console.ReadLine();
            list.IndexOf(v);
            Console.WriteLine("Result: " + list.IndexOf(v));
            Console.WriteLine("5. Contains value in object");
            Console.WriteLine("Please, enter value in list:");
            var u = Console.ReadLine();
            bool cong = list.Contains(u);
            Console.WriteLine("Result: " + cong);
            Console.WriteLine("6.Gets items at the specified index");
            Console.WriteLine("Enter index and get value:");
            var g = Console.ReadLine();
            list.Get(int.Parse(g));
            Console.WriteLine("Result: " + list.Get(int.Parse(g)));
            Console.WriteLine("7. Clear the list");
            list.Clear();
            Console.WriteLine("List was cleared!");
        }
        
        public static LinkedList addList(LinkedList list)
        {
            Console.WriteLine("Добавьте 4 элементa списка");
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            list.Add(Console.ReadLine());
            Console.WriteLine("Number of List: " + list.Count);

            return list;
        }

        static LinkedList addListByIndex(LinkedList list)
        {
            Console.WriteLine("Please input index");
            var s = Console.ReadLine();
            Console.WriteLine("Please input data in list:");
            var n = Console.ReadLine();
            list.Add(int.Parse(s), n);
            Console.WriteLine("Number of list: " + list.Count);

            return list;
        }
        
    }
}