using DataStructures;

MyQueue<int> test = new MyQueue<int>(5);

test.Enqueue(2);
test.Enqueue(3);
test.Enqueue(4);
test.Enqueue(5);

Console.WriteLine(test.Dequeue());
