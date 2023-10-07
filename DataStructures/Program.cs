using DataStructures;

//MyQueue<int> test = new MyQueue<int>(5);

//test.Enqueue(2);
//test.Enqueue(3);
//test.Enqueue(4);
//test.Enqueue(5);

//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}


MyStack<int> test = new MyStack<int>(5);

test.Push(2);
test.Push(3);
test.Push(4);
test.Push(5);
test.Push(8);

//foreach (var item in test)
//{
//    Console.WriteLine(item);
//}

Console.WriteLine(test.Pop());
