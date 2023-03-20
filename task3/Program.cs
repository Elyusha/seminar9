// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int FuncAkkermanRec(int m, int n)
{
    int result = 0;

    if (m >= 0 && n >= 0)
    {
        if (m == 0) result = n + 1;
        else if (n == 0) result = FuncAkkermanRec(m - 1, 1);
        else result = FuncAkkermanRec(m - 1, FuncAkkermanRec(m, n - 1));
    }

    else
    {
        Console.WriteLine("Введите неотрицательные целые числа!");
    }
    return result;

}

int m = Promt("Введите первое число: ");
int n = Promt("Введите второе число: ");
Console.WriteLine($"Результат FuncAkkerman({m}, {n}) = {FuncAkkermanRec(m, n)}");
