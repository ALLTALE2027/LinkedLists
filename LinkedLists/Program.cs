namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List!!!");
            var linkedList=new LinkedList();

            Console.WriteLine("Press 1 To create a linked List");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
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