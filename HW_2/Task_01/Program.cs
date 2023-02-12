//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int boba = n/10;
System.Console.WriteLine(boba); //Делим на 10. Получаем двузначное ЦЕЛОЕ число
int bob = boba%10;
System.Console.WriteLine(bob); //Берем двузначное чило и получаем остаток