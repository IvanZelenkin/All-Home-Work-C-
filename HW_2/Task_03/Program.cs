// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        System.Console.WriteLine("Понедельник. Не выходной");
        break;
    case 2:
        System.Console.WriteLine("Втроник. Не выходной");
        break;
    case 3:
        System.Console.WriteLine("Среда. Не выходной");
        break;
    case 4:
        System.Console.WriteLine("Четверг. Не выходной");
        break;
    case 5:
        System.Console.WriteLine("Пятница. Не выходной");
        break;
    case 6:
        System.Console.WriteLine("Суббота. Ура выходной!");
        break;
    case 7:
        System.Console.WriteLine("Воскресенье. Ура выходной!");
        break;
    default:
        System.Console.WriteLine("Введено неверное число");
        break;
}