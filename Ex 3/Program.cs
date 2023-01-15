//Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;
Clear();


Write("Введите количество элементов массива: ");
int.TryParse(ReadLine(), out int num);

int num_abs = Math.Abs(num);
PrintRandArray(RandArray(num_abs));
//ReadLine();



int[] RandArray(int size)
{
	int[] array = new int[size];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(101);
	}
	return array;
}

void PrintRandArray(int[] array)
{
	int count = array.Length;

	for (int i = 0; i < count; i++)
	{
		Write($"{array[i]} ");
	}
	//WriteLine(array);
}
