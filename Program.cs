
Console.WriteLine("Введи пятизначное число :");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.WriteLine("Это не пятизначное число, введи ПЯТИЗНАЧНОЕ число : ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 > 9999 && num2 < 100000)
    {
        num += num2;
    }
}
if (num/10000==num%10 && num/1000%10==num/10%10)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}









