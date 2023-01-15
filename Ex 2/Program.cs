//Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

Write("Введите число: ");
int.TryParse(ReadLine(), out int num);

WriteLine(SummNumber(num));





int SummNumber(int number)
{
	int result = 0;
	int tempnumber = Math.Abs(number);

	while (Math.Abs(tempnumber) > 0)
	{
		result += tempnumber % 10;
		tempnumber = tempnumber / 10;
	}

	return result;
}