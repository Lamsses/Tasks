//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;

//namespace ConsoleApp8;

//public class Node
//{
//    public int? data;
//    public Node? next;
//    public Node? prev;
//    public Node(int value)
//    {
//        data = value;
//        next = null;
//        prev = null;
//    }

//}

//public class DoubleLinkedList
//{
//    public static Node? head;
//    public static Node? tail;
//    public int count =0;

//    public DoubleLinkedList()
//    {
//        head = null;
//        tail = null;
//    }

//    public void AddFirst(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//        }
//        else
//        {
//            Node? newHead = new Node(value);
//            newHead.next = head;
//            head.prev = newHead;
//            head = newHead;



//        }
//        ++count;
//    }
//    public void AddLast(int value)
//    {
//        if (head == null)
//        {
//            head = new Node(value);
//            tail = head;

//        }
//        else
//        {
//            Node newTail = new Node(value);

//            tail.next = newTail;
//            newTail.prev = tail;
//            tail = newTail;
//        }
//        ++count;

//    }
//    public void delete()
//    {
//        if (head == null)
//        {
//            Console.WriteLine("empty");

//        }
//        else if (count == 1)
//        {
//         head = null;
//        }else
//        {
//         tail = tail.prev;
//         tail.next = null;
//        }
//        --count;
//    }
//    public void Display()
//    {
//        int count = 0;
//        Node currentHead = head;
//        Console.WriteLine("Data entered on the list are :");

//        while (currentHead != null)
//        {
//            Console.Write("node number {0}:", ++count);
//            Console.WriteLine(currentHead.data);
//            currentHead = currentHead.next;
//        }

//    }


//}

//public class program
//{
//    public static void Main(string[] args)
//    {
//        DoubleLinkedList newlist = new DoubleLinkedList();
//        Console.WriteLine("enter number of nodes");
//        int nodes = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < nodes; i++)
//        {
//            Console.Write("enter input {0}:", i + 1);
//            int input = Convert.ToInt32(Console.ReadLine());
//            newlist.AddLast(input);

//        }
//        newlist.Display();

//        Console.WriteLine(" After deletion the new list are:");
//        newlist.delete();

//        newlist.Display();
//    }
//}