namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!!!");
            var linkedList=new LinkedList();

            Console.WriteLine("1. To create a linked List");
            Console.WriteLine("2. Add node from Head");
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
                default:
                    Console.WriteLine("Select a proper choice");
                    break;
            }
        }
    }
}