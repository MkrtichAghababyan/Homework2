
//array sort
//int n = int.Parse(Console.ReadLine());
//int[] arr = new int[n];
//Random rnd = new Random();
//for (int i = 0; i < n; i++)
//{
//    arr[i] = rnd.Next(0,100);
//    Console.WriteLine(arr[i]);
//}
//int c = 0;
//for (int i = 0;i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (arr[i] < arr[j])
//        {
//            c = arr[i];
//            arr[i] = arr[j];
//            arr[j] = c;
//        }   
//    }
//}
//Console.WriteLine();
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//List Sort
//int n = int.Parse(Console.ReadLine());
//List<int> list = new List<int>();
//Random rnd = new Random();
//for (int i = 0; i < n; i++)
//{
//    list.Add(rnd.Next(0, 100));
//}
//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}
//int c = 0;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (list[i] < list[j])
//        {
//            c = list[i];
//            list[i] = list[j];
//            list[j] = c;
//        }
//    }
//}
//Console.WriteLine();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}

//IList Sort
//int n = int.Parse(Console.ReadLine());
//IList<int> list = new List<int>();
//Random rnd = new Random();
//for (int i = 0; i < n; i++)
//{
//    list.Add(rnd.Next(0, 100));
//}
//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}
//int c = 0;
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (list[i] < list[j])
//        {
//            c = list[i];
//            list[i] = list[j];
//            list[j] = c;
//        }
//    }
//}
//Console.WriteLine();
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//Stack Sort
//int n = int.Parse(Console.ReadLine());
//Random random = new Random();   
//Stack<int> stack = new Stack<int>();
//for (int i = 0; i < n; i++)
//{
//    stack.Push(random.Next(0,100));
//}
//foreach (int i in stack)
//{
//    Console.WriteLine(i);
//}
//stack = Sort(stack);
//Console.WriteLine("Sorted stack:");
//foreach (int i in stack)
//{
//    Console.WriteLine(i);
//}


//Queue Sort
using System.Net.Quic;

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(20);
queue.Enqueue(-31);
queue.Enqueue(50);
queue.Enqueue(-5);
List<int> list = new List<int>();   
int num = 0;
int num2 = 0;
while (queue.Count>0)
{
    num  = queue.Dequeue();
    num2 = queue.Dequeue();
    if (num < num2)
    {
        queue.Enqueue(num);
        list.Add(num);
    }
    else
    {
        queue.Enqueue(num2);
        list.Add(num2);
    }
    Console.WriteLine("Count:{0}",queue.Count);
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}




















Stack<int> Sort(Stack<int> stack)
{
    Stack<int> temp = new Stack<int>();
    //Until all elements are moved
    while (stack.Count > 0)
    {
        var element = stack.Pop();
        //If peek element in temp stack is grater than item we want to insert
        //Pop elements from temp and push in stack until we have correct position for element
        while (temp.Count > 0 && element > temp.Peek())
        {
            stack.Push(temp.Pop());
        }
        //Push element at its right position
        temp.Push(element);
    }
    return temp;
}
