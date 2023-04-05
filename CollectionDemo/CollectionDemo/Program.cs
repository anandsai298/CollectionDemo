// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CollectionDemo;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("DoListDemo:");
        DoListDemo();
        Console.WriteLine("DoStackDemo:");
        DoStackDemo();
        Console.WriteLine("DoDictionaryDemo:");
        DoDictionaryDemo();
        Console.WriteLine("DoQueueDemo:");
        DoQueueDemo();
        Console.WriteLine("DoSetDemo:");
        DoSetDemo();
    }

    public static void DoListDemo()
    {
        List<string> list = new List<string>();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        list.Add("d");
        list.Remove("d");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    public static void DoStackDemo()//LIFO
    {
        Stack<string> list = new Stack<string>();
        list.Push("a");
        list.Push("b");
        list.Push("c");
        list.Push("d");
        list.Pop();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    public static void DoDictionaryDemo()//LIFO
    {
        Dictionary<int, string> list = new Dictionary<int, string>();
        list.Add(1, "a");
        list.Add(2, "b");
        list.Add(3, "c");
        list.Add(4, "d");
        list.Remove(4);
        foreach (var item in list)
        {
            Console.WriteLine("Key-->" + item.Key + "\nValue-->" + item.Value);
        }
    }
    public static void DoQueueDemo()
    {
        Queue<string> list = new Queue<string>();
        list.Enqueue("a");
        list.Enqueue("b");
        list.Enqueue("c");
        list.Enqueue("d");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.Dequeue();
        Console.WriteLine("_______");
        Queue<string>.Enumerator queue = list.GetEnumerator();
        while(queue.MoveNext())
        {
            Console.WriteLine(queue.Current);
        }
    }
    public static void DoSetDemo()
    {
        HashSet<string> list = new HashSet<string>();
        list.Add("a");
        list.Add("b");
        list.Add("c");
        list.Add("d");
        list.Add("b");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.Remove("c");
        Console.WriteLine("_______");
        HashSet<string>.Enumerator hash = list.GetEnumerator();
        while (hash.MoveNext())
        {
            Console.WriteLine(hash.Current);
        }
    }
}

