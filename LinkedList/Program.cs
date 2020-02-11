using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            LinkedList list = new LinkedList();
            var i = list.Count;
            while (i < 6) {
                Console.WriteLine("Welcome, guest");
                Console.WriteLine("1. Add an item to the list at specified index");
                Console.WriteLine("2. Add an item to the END of the list");
                Console.WriteLine("3. Remove the item in the list at the specified index");
                Console.WriteLine("4. Clear the list");
                Console.WriteLine("5. Get the index of the item in the list");
                Console.WriteLine("6. Contains value in object");
                Console.WriteLine("7.Gets items at the specified index");
            
                var a = Console.ReadLine();
                switch (a)
                {
                    case "1" :
                        addList(list);
                        break;
                    case "2" :
                        addListByIndex(list);
                        break;
                    case "3" :
                        var t = Console.ReadLine();
                        list.Delete(int.Parse(t));
                        Console.WriteLine("Size of list: " + list.Count);
                        break;
                    case "4":
                        list.Clear();
                        Console.WriteLine("List was cleared!");
                        break;
                    case "5":
                        Console.WriteLine("You enter an index for get item");
                        var v = Console.ReadLine();
                        list.IndexOf(v);
                        Console.WriteLine("Result: " + list.IndexOf(v));
                        break;
                    case "6":
                        Console.WriteLine("Please, enter value in list:");
                        var u = Console.ReadLine();
                        bool cong = list.Contains(u);
                        Console.WriteLine("Result: " + cong);
                        break;
                    case "7":
                        Console.WriteLine("Enter index and get value:");
                        var g = Console.ReadLine();
                        list.Get(int.Parse(g));
                        Console.WriteLine("Result: " + list.Get(int.Parse(g)));
                        break;
                    default:
                        Console.WriteLine("You enter an unknown number");
                        break;
                }
            }
            
        }
        
        static LinkedList addList(LinkedList list)
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