using System.ComponentModel;

Console.WriteLine("Введiть цiле число n:");
int n;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n >= 1)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Число менше 1");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введено некоректне значення. Будь ласка, введiть цiле число.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}


Console.WriteLine("Dictionary keys:");
    int numberOfKeys;
    while (true)
    {
    if (int.TryParse(Console.ReadLine(), out numberOfKeys))
    {
        if ((numberOfKeys > 0) && (numberOfKeys > n))
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number is less than 1 or less than n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Введено некоректне значення. Будь ласка, введiть цiле число.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    }

    Dictionary<int, string> dict = new Dictionary<int, string>();

    for (int i = 1; i <= numberOfKeys; i++)
    {
        Console.Write($"Key {i}:  ");
        dict.Add(i, Console.ReadLine());
        

    }

    var sort = from i in dict
               where i.Key >= n
               select i;

    Console.WriteLine("      ");
    Console.WriteLine("Result");

    foreach (var item in sort)
    {
        Console.WriteLine("Key: " + item.Key + "    Value:" + item.Value);
    }
