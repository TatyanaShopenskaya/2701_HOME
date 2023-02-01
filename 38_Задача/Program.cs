// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2        //вещественные числа-числа, у кот есть дробная часть


double[] CreateArrayRndDouble(int size, int min, int max)     //double-для вещественных чисел
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min)+min), 1);
        // array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);   //Math.Round-для округления
    } 
    return array;
}

//напечатаем массив
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}   ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int i = 0;
//найдем макс.значение массива

double MaxNumber(double[] array)
{
    double max = array[i];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

//найдем мин.значение массива

double MinNumber(double[] array)
{
    double min=array[i];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min=array[i];
    }
    return min;
}


Console.WriteLine("Укажите длину массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());
double[] arrayNumb = CreateArrayRndDouble(sizeArray, 0, 100);
PrintArrayDouble(arrayNumb);
double maxNumber = MaxNumber(arrayNumb);
// Console.WriteLine($"{maxNumber}");
double minNumber = MinNumber(arrayNumb);
// Console.WriteLine($"{minNumber}");

//Находим разницу
double difference = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {Math.Round(difference, 1)}");
