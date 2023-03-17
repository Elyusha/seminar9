// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumRec(int min, int max)
{
    if (max < min) return 0;
    else return max + SumRec(min, max - 1);
}

int m = Promt("Введите первое число: ");
int n = Promt("Введите второе число: ");
Console.WriteLine(SumRec(m, n));
