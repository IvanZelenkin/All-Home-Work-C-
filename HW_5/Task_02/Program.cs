// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
    System.Console.Write("[" + string.Join(",", array) + "]");
}

int OddSum(int[] array)
{
    int number = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        number = array[i] + number;
    }
    return number;
}


int[] arry = GenerateArray(4, 1, 10);
PrintArray(arry);
int sumodd = OddSum(arry);
System.Console.Write(sumodd);