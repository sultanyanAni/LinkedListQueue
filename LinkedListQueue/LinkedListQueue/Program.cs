using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            int currentNum = 0;
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1) Add at the beginning");
                Console.WriteLine("2) Add at the end");
                Console.WriteLine("3) Add after a node");
                Console.WriteLine("4) Add before a node");
                Console.WriteLine("5) View the list");

                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        list.AddFirst(currentNum);
                        currentNum++;
                        break;

                    case "2":
                        list.AddLast(currentNum);
                        currentNum++;
                        break;

                    case "3":
                        list.AddAfter(list.Head, currentNum);
                        currentNum++;
                        break;
                    case "4":
                        list.AddBefore(list.Tail, currentNum);
                        currentNum++;
                        break;

                    case "5":
                        Console.WriteLine("here it is:");
                        foreach (Node<int> node in list)
                        {
                            Console.WriteLine(node.Value);
                        }
                        break;
                }
           
            }
        }
    }
}
