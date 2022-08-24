namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!!!");
            var linkedList=new LinkedList();

            Console.WriteLine("1. To create a linked List");
            Console.WriteLine("2. Add node from Head/Front");
            Console.WriteLine("3. Add node from Tail/Last");
            Console.WriteLine("4. Insert node in between");
            Console.WriteLine("5. Delete first element");
            Console.WriteLine("6. Delete last  element");
            Console.WriteLine("7. Search node in list");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    linkedList.AddNode(70);
                    linkedList.AddNode(30);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();
                    break;
                case 2:
                    linkedList.AddNode(70);
                    linkedList.AddNode(30);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();
                    break;
                case 3:
                    linkedList.AppendNode(56);
                    linkedList.AppendNode(30);
                    linkedList.AppendNode(70);
                    linkedList.DisplayNodes();
                    break;
                case 4:
                    linkedList.AddNode(70);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();
                    linkedList.InsertNode(30,56);
                    linkedList.DisplayNodes();
                    break;
                case 5:
                    linkedList.AddNode(70);
                    linkedList.AddNode(30);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();

                    linkedList.DeleteFirstNode();
                    linkedList.DisplayNodes();
                    break;

                case 6:
                    linkedList.AddNode(70);
                    linkedList.AddNode(30);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();

                    linkedList.DeleteLastNode();
                    linkedList.DisplayNodes();
                    break;
                case 7:
                    linkedList.AddNode(70);
                    linkedList.AddNode(30);
                    linkedList.AddNode(56);
                    linkedList.DisplayNodes();

                    linkedList.SearchNode(30);

                    break;



                default:
                    Console.WriteLine("Select a proper choice");
                    break;
            }
        }
    }
}