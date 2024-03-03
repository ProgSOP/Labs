Console.WriteLine("Number of peaple:");
int N;
int k = 2;

while (true)
{
    N = int.Parse(Console.ReadLine());
    if (N <= 1)
    {
        Console.WriteLine("value is too short");

    }
    else
    {
        break;
    }
}

LinkedList<int> circle = new LinkedList<int>();

for (int i = 1; i <= N; i++)
{
    circle.AddLast(i);
    
}

int index = 0;


var node = circle.First;

while (circle.Count > 1)
{
    for (int i = 1; i < k; i++)
    {
        node = node.Next ?? circle.First;
    }

    var nextNode = node.Next ?? circle.First;
    circle.Remove(node);
    node = nextNode;
}

Console.WriteLine($"Last one: {circle.First.Value}");
   


