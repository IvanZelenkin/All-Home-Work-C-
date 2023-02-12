// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
 
if (n>99) //Число больше 99
{ 
    while (n>999) 
    {
        n /=10;
    }
    System.Console.WriteLine(n%10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет.");
}