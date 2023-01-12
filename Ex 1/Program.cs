//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int num);

int sum = CountDigit(num);
WriteLine($"{sum}");



int CountDigit(int num)
{
	int result = 0;

	while (Math.Abs(num) > 0)
	{
		num /= 10;
		result += 1;
	}

	return result;
}