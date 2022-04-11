// 1) Найти сумму цифр числа

int sumNumbers(int num)
{	
	if (num > 0) return (num % 10 + sumNumbers(num / 10) );
	else return 0;
}

Console.WriteLine("Введи число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр: " + sumNumbers(num));
