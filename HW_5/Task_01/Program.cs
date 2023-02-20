// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] GenerateArray(int size, int LR, int RR)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(LR, RR + 1);
    }
    return array;
}

void PrintArray(int[] array)

{
    System.Console.Write("[" + string.Join(",", array) + "]" );
}

int FindEven(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        {
            countEven++;
        }
    }
    return countEven;
}

int[] arr = GenerateArray(4, 100, 999);
int count = FindEven(arr);
PrintArray(arr);
System.Console.Write(" -> " + count);