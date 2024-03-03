using System;
using System.Collections;


Console.Write("Write N:");
int N;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out N))
    {
        if (N >= 1)
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

int k = 2;
        ArrayList circle = new ArrayList();

        for (int i = 1; i <= N; i++)
        {
            circle.Add(i);
        }

        int index = 0;
        while (circle.Count > 1)
        {
            index = (index + k - 1) % circle.Count;
            circle.RemoveAt(index);
        }

      
        Console.WriteLine($"Остання залишився: {circle[0]}");
    

