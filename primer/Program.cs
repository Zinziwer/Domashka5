
void FillArray(int[] collection, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(minValue, maxValue);
    }
}
void FillArray2(double[] collection, int minValue = 0, int maxValue = 10)
{
    maxValue++;
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = Math.Round((new Random().NextDouble()) * (new Random().Next(minValue, maxValue)), 2);
    }
}

double MinNumber(double[] numb)
{
    double tmpMin = numb[0];
    for (int i = 1; i < numb.Length; i++)
    {
        if (tmpMin > numb[i])
        {
            tmpMin = numb[i];
        }
    }
    return tmpMin;
}
double MaxNumber(double[] numb)
{

    double tmpMax = numb[0];
    for (int i = 1; i < numb.Length; i++)
    {
        if (tmpMax < numb[i])
        {
            tmpMax = numb[i];
        }
    }
    return tmpMax;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write(col[position] + " ");
    }
}
void PrintArray2(double[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write(col[position] + "   ");
    }
}

int EvenCount(int[] numb)
{
    int count = 0;
    for (int i = 0; i < numb.Length; i++)
    {
        if (numb[i] % 2 == 0) count++;
    }
    return count;
}
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.//
void Zadacha34()
{
    Random random = new Random();
    int size = random.Next(10, 15);
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    Console.WriteLine();
    Console.WriteLine($"Count of even numbers = {EvenCount(numbers)}");
}
Zadacha34();

//Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов с нечётными индексами.
void Zadacha36()
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] numbers = new int[size];
    FillArray(numbers, -10, 11);
    PrintArray(numbers);
    Console.WriteLine();
    int sum = numbers[1];
    for (int i = 3; i < numbers.Length; i = i + 2)
    {
        sum += numbers[i];
    }
    Console.WriteLine($"Summa elementov s nechetnym indeksom = {sum}");
}
Zadacha36();

//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha38()
{
    Random random = new Random();
    int size = random.Next(4, 15);
    double[] numbers = new double[size];
    FillArray2(numbers, 2, 40);
    PrintArray2(numbers);
    double minn = MinNumber(numbers);
    double maxn = MaxNumber(numbers);
    Console.WriteLine();
    Console.WriteLine($"Raznitsa meszdu  {maxn}  i  {minn}  = {Math.Round((maxn - minn), 2)}"); // без округления почему-то иногда вылезает длинное после запятой число
}
Zadacha38();
//