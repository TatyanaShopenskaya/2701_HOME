// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


//создать массив
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

//напечатать массив
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

// ищем количество четных чисел в массиве

int CountEvenNumber(int[] array) 
{   
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// Создание массива, ввод числа пользователем, вызов функции.
Console.WriteLine("Укажите длину массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = CreateArrayRndInt(sizeArray, 100, 999);
PrintArray(arrayNumb);

int countEvenNumber = CountEvenNumber(arrayNumb);
Console.WriteLine($"Количество чётных чисел в массиве = {countEvenNumber}");


