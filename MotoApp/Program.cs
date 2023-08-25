using MotoApp;

var stack = new MyStack<float>();
stack.Push(item: 4.5f);
stack.Push(item: 43);
stack.Push(item: 333.6f);

var stackCh = new Stack<char>();
stackCh.Push(item: 'c');
stackCh.Push(item: 'D');
stackCh.Push(item: 'a');

float sum = 0;

while (stackCh.Count > 0)
{
    char item = stackCh.Pop();
    Console.WriteLine( $"Item: {item}");
    //sum += item;
}

while (stack.Count > 0)
{
    float item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}