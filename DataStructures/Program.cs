using DataStructures.LinkedList;

MyLinkedList<int> newItems = new();

newItems.Add(1);
newItems.Add(2);
newItems.Add(3);
newItems.Add(4);

LinkedList<int> newList = new();

Test.Test1 test1 = new Test.Test1();

test1.Age = 10;


class Test
{
    public class Test1
    {
        public int Age { get; set; }
    }
}