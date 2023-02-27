// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string text)
{
    System.Console.Write(text);
    string val = System.Console.ReadLine();
    int res = Convert.ToInt32(val);
    return res;
}

int[] InputArray(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Введите {i + 1}ый элемент");
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {arr[i]}");
    }
}

int CountPositivNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Prompt("Введите кол-во элементов");
int[] array;
array = InputArray(lenght);
PrintArr(array);
System.Console.WriteLine($"{CountPositivNumber(array)}");