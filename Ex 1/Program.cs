// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
//В задаче не использвать стандартный метод Pow!


using static System.Console;
Clear();

Write("Введите число A: ");
int.TryParse(ReadLine(), out int a);
Write("Введите число B: ");
int.TryParse(ReadLine(), out int b);

WriteLine(NotPow(a, b));






int NotPow(int num1, int num2)
{
	int result = 1;
	int count = 0;

	while (count < Math.Abs(num2))
	{
		result *= num1;
		count++;
	}
	return result;
}
