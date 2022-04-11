//2)Написать программу вычисления функции Аккермана

int ackermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return ackermanFunc(m - 1, 1);
    else return ackermanFunc(m - 1, ackermanFunc(m, n - 1));
}

Console.WriteLine("Введи число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введи число n: ");
int n = int.Parse(Console.ReadLine());

int res = ackermanFunc(m, n); 
Console.WriteLine("Реультат: " + res);

