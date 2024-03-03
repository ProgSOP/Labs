Console.WriteLine("Введiть кiлькiсть чисел n:");
int n;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out n))
    {
        if (n >= 3)
        {
            break;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Число менше 3");
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

Dictionary<int,int> dic = new Dictionary<int,int>();

for (int i = 1; i <= n; i++)
{
    Console.Write($"Введiть значення для ключа {i}: ");
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        dic.Add(i, value);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Некоректне значення. Введiть цiле число.");
        i--;
        Console.ForegroundColor = ConsoleColor.White;
    }
}


Console.WriteLine("Result: ");

var group = from item in dic
            where item.Value > 0 
            select item;

foreach (var i in group)
{
    Console.WriteLine(i.Value);
}