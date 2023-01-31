// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//заполняем массив
int[] CreateArrayRndInt(int size, int min, int max) 
{   
    int[] array = new int[size]; 
    Random rnd = new Random();   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1); 
    }
    return array; 
}

//напечатаем массив
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// ищем сумму элементов, стоящих на нечётных позициях.
int sum=0;
int SumNumbersOddIndex(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum=sum+array[i];
        }
    }
    return sum;
}

// Создание массива, ввод числа пользователем, вызов функции.
Console.WriteLine("Укажите длину массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArrayRndInt(sizeArray, -10, 10);
PrintArray(arrayNumb);

int sumNumbersOddIndex = SumNumbersOddIndex(arrayNumb);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumNumbersOddIndex}");