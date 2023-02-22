// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double diff = max - min;
    return diff;
}

void PrintArray(double[] array)
{
    System.Console.Write("[" + string.Join(". ", array) + "]");
}

double[] myarr = { 3.2, 7.4, 22.8, 2.3, 78.7 };
double diff = FindDifference(myarr);
PrintArray(myarr);
System.Console.Write(" -> " + diff);