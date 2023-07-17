using MyQueue;

MyQueueCls<string> obj= new MyQueueCls<string>(5);
MyQueueCls<int> obj2= new MyQueueCls<int>(5);

obj.Enqueue("Aydin");
obj.Enqueue("Salih");
obj.Enqueue("Beyza");
obj.Enqueue("Melis");
obj.Enqueue("Onat");

Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());
Console.WriteLine(obj.Dequeue());

obj2.Enqueue(1);
obj2.Enqueue(2);
Console.WriteLine(obj2.Dequeue());
Console.WriteLine(obj2.Dequeue());