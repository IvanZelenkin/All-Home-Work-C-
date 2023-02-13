// Напишите программу, которая принимает на вход ПЯТИЗНАЧНОЕ число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
int n = InputNumber("Введите пятизначное число: ");

int n1 = n / 10000;
int n2 = n % 10000 / 1000;
int n3 = n % 1000 / 100;
int n4 = n % 100 / 10;
int n5 = n % 10;

if (n1 == n5 && n2 == n4)
{
System.Console.WriteLine("Число является палиндромом!");    
}
else
{
System.Console.WriteLine("Число не является палиндромом, или введено не верно");
}