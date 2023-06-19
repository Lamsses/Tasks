
using System;

namespace ConsoleApp8;

public class Node
{
    public int? data;
    public Node? next;
    public Node(int value)
    {
        data = value;
        next = null;
    }

}

public class DoubleLinkedList
{
    public static Node? head;

    public DoubleLinkedList()
    {
        head = null;
    }

    public void AddFirst(int value)
    {
        if (head == null)
        {
            head = new Node(value);
        }
        else
        {
            Node? newHead = new Node(value);
            Node temp = head;

            newHead.next = head;
            head = newHead;
        }
    }
    public void AddLast(int value)
    {

        if (head == null)
        {
            head = new Node(value);
            head.next = head;
        }
        else
        {


            Node newHead = new Node(value);
            Node temp = head;

            while (temp.next != head)
            {
                temp = temp.next;
            }
            temp.next = newHead;
            newHead.next = head;


        }
    }
    public void Display()
    {
        int count = 0;
        Node currentHead = head;
        Console.WriteLine("Data entered in the list are :");
        do
        {
            Console.Write("node number {0}:", ++count);
            Console.WriteLine(currentHead.data);
            currentHead = currentHead.next;
            head = currentHead;
        }
        while ( head.next != head);


    }


}

public class program
{
    public static void Main(string[] args)
    {
        DoubleLinkedList newlist = new DoubleLinkedList();
        Console.WriteLine("enter number of nodes");
        int nodes = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= nodes; i++)
        {
            Console.Write("enter input {0}:", i);
            int input = Convert.ToInt32(Console.ReadLine());
            newlist.AddLast(input);

        }
        Console.WriteLine("Write your number");
        var num = Console.ReadLine();
        newlist.AddFirst(Convert.ToInt32(num));

        newlist.Display();
    }
}

