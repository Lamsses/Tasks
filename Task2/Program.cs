using System;
//Q1
//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        Console.WriteLine("Singly Linked List:");
//        linkedList.DisplayList();
//    }
//}



////Q2


//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public void DisplayReverse()
//    {
//        ReversePrint(head);
//    }

//    private void ReversePrint(Node node)
//    {
//        if (node == null)
//            return;

//        ReversePrint(node.next);
//        Console.Write(node.data + " ");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        // Add nodes to the linked list
//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        Console.WriteLine("Singly Linked List (Reverse Order):");
//        linkedList.DisplayReverse();
//    }
//}

//Q3

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;
//    public int count = 0;


//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;

//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;


//            }
//            current.next = newNode;
//        }
//        count++;

//    }

//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//        Console.WriteLine(count);

//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.AddNode(7);
//        linkedList.AddNode(9);



//        Console.WriteLine("Singly Linked List:");
//        linkedList.DisplayList();
//    }
//}


//Q4

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;
//    public int count = 0;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {

//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void AddNode(int value, int position)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {

//            Node current = head;

//            while (current != null)
//            {
//                if(count == position-1)
//                {
//                    newNode.next = current.next;
//                    current.next = newNode;

//                    break;
//                }
//                count++;
//                current = current.next;
//            }

//        }
//    }

//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(6);
//        linkedList.AddNode(2);
//        linkedList.AddNode(4,1);

//        linkedList.AddNode(3);
//        linkedList.AddNode(5);
//        linkedList.AddNode(7, 2);



//        Console.WriteLine("Singly Linked List:");
//        linkedList.DisplayList();
//    }
//}


//Q5

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        { 
//            newNode.next = head;
//            head = newNode;
//        }
//    }


//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(5);


//        Console.WriteLine("Singly Linked List:");
//        linkedList.DisplayList();
//    }
//}


//Q6 
//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        Console.WriteLine("Singly Linked List:");
//        linkedList.DisplayList();
//    }
//}

//Q7
//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }

//    public int GetNode(int position)
//    {
//        Node current = head;
//        int currentPosition = 0;

//        while (current != null)
//        {
//            if (currentPosition == position)
//            {
//                return current.data;
//            }
//            current = current.next;
//            currentPosition++;
//        }

//        return -1;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.DisplayList();
//        int position = Convert.ToInt32(Console.ReadLine());
//        var node = linkedList.GetNode(position);

//        if (node != null)
//        {
//            Console.WriteLine("Node at position {0}: {1}", position, node);
//        }
//        else
//        {
//            Console.WriteLine("Node not found at position {0}", position);
//        }
//    }
//}

//Q8

//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public int GetIndex(int data)
//    {
//        Node current = head;
//        int currentPosition = 0;

//        while (current != null)
//        {
//            if (current.data == data)
//            {
//                return currentPosition;
//            }
//            current = current.next;
//            currentPosition++;
//        }


//        return -1;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);


//        int position = Convert.ToInt32(Console.ReadLine());

//        var node = linkedList.GetIndex(position);

//        if (node != null)
//        {
//            Console.WriteLine("Node at position {0}: {1}", position, node);
//        }
//        else
//        {
//            Console.WriteLine("Node not found at position {0}", position);
//        }
//    }
//}

//Q9

//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public bool check()
//    {

//        if (head == null)
//        {
//            Console.WriteLine("empty");
//            return true;        }
//        else
//        {
//            Console.WriteLine(" not empty");

//            return false;
//        }
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        linkedList.check();
//        int position = Convert.ToInt32(Console.ReadLine());



//    }
//}

//Q10

//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void  change()
//    {

//        head.next = null;
//    }
//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        linkedList.change();
//        linkedList.DisplayList();
//        int position = Convert.ToInt32(Console.ReadLine());



//    }
//}
//Q11

//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void delete(int position)
//    {
//        Node current = head;
//        int currentPosition = 0;

//        while (current != null)
//        {
//            if ((currentPosition+1) == position)
//            {
//                current.next = current.next.next;


//            }
//            current = current.next;
//            currentPosition++;
//        }
//    }
//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        linkedList.delete(2);
//        linkedList.DisplayList();
//        int position = Convert.ToInt32(Console.ReadLine());



//    }
//}
//Q12
//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;
//    public int count = 0;


//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;

//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;


//            }
//            current.next = newNode;
//        }
//        count++;

//    }

//    public void counter()
//    {

//        Console.WriteLine(count);

//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.AddNode(6);



//        Console.WriteLine("length is : ");
//        linkedList.counter();
//    }
//}
//Q13

//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void change()
//    {

//        head = head.next;
//    }
//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);

//        linkedList.change();
//        linkedList.DisplayList();
//        int position = Convert.ToInt32(Console.ReadLine());



//    }
//}
//Q14
//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void delete()
//    {

//        Node current = head;
//        while (current != null)
//        {
//            if (current.next.next == null)

//                current.next = null;

//            current = current.next;
//        }

//    }
//    public void DisplayList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.AddNode(1231);

//        linkedList.delete();
//        linkedList.DisplayList();

//    }
//}
//Q15
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public int[] convert()
//    {
//        List<int> list = new List<int>();
//        Node current = head;
//        while (current != null)
//        {
//            list.Add(current.data);
//            current = current.next;
//        }

//        return list.ToArray();
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.AddNode(1231);

//        foreach (int item in linkedList.convert())
//        {
//            Console.Write(item + " ");
//        }
//    }
//}
//Q16
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public string convert()
//    {
//        string tem="";
//        Node current = head;
//        while (current != null)
//        {
//            tem += Convert.ToString(current.data)+" ";
//            current = current.next;
//        }

//        return tem;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        linkedList.AddNode(6);
//        linkedList.AddNode(9);

//        Console.Write(linkedList.convert());

//    }
//}
//Q17
//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public int GetNodeIndex(int value)
//    {
//        Node current = head;
//        int currentPosition = 0;

//        while (current != null)
//        {
//            if (current.data == value)
//            {
//                return currentPosition;
//            }
//            current = current.next;
//            currentPosition++;
//        }

//        return -1;
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        Console.Write( "enter value :");
//        int index = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("index : "+ linkedList.GetNodeIndex(index)); 

//    }
//}
//Q18
//using System;

//public class Node
//{
//    public int data;
//    public Node next;

//    public Node(int value)
//    {
//        data = value;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    private Node head;

//    public LinkedList()
//    {
//        head = null;
//    }

//    public void AddNode(int value)
//    {
//        Node newNode = new Node(value);

//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }

//    public void check(int value)
//    {
//        bool flag=false;
//        Node current = head;
//        while (current != null)
//        {
//            if (current.data == value)
//            {
//                flag = true;               
//            }
//            current = current.next;
//        }
//        if (flag)
//        {
//            Console.WriteLine("item found");

//        }else
//            Console.WriteLine("item not  found");


//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        LinkedList linkedList = new LinkedList();

//        linkedList.AddNode(1);
//        linkedList.AddNode(2);
//        linkedList.AddNode(3);
//        linkedList.AddNode(4);
//        linkedList.AddNode(5);
//        Console.Write("enter value :");
//        int value = Convert.ToInt32(Console.ReadLine());
//        linkedList.check(value);
//    }
//}
