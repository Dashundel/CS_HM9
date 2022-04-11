//4)Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

void sumNumbers(int a, int b, int n)
{
	int c;
	
    if (n > 2)
	{
        c = a + b;
	    Console.Write(c + " ");
        a = b;
        b = c;
	    if (n > 1) sumNumbers(a, b, n - 1);
    }
    /*else if(n==1) Console.Write(a + " "); 
    else if(n==2) 
    { 
        Console.Write(a + " "); 
        Console.Write(b + " "); 
    } */  
}

Console.WriteLine("Введи первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введи количество чисел: ");
int n = int.Parse(Console.ReadLine());

if (n >= 2)
{
    Console.Write(a + " ");
    Console.Write(b + " ");
    sumNumbers(a, b, n);
}
else if (n == 1) Console.Write(a + " ");

