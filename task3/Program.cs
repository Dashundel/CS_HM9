//3)Написать программу возведения числа А в целую стень B

int numDegree(int num, int degree)
{
	if (degree > 1) return numDegree(num, degree - 1) * num;
	return num;	
}

Console.WriteLine("Введи число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введи степень B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Результат: " + numDegree(a, b));

