//Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int NumsRec(int num)
{
    if (num == 0) return 1;
    if (num < 0)
    {
        Console.WriteLine($"Ваше число {num} ненатуральное");
        return 0;
    }
    else
    {
        Console.Write($"{num,3}");
        return NumsRec(num - 1);
    }
}

int n = Promt("Введите N: ");
NumsRec(n);
