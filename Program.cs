Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99&&num<1000)
{
string chr = Convert.ToString(num);
System.Console.WriteLine ($"{chr[1]}");
}
else
{
    Console.WriteLine("Введите трехзначное число");
}


/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/