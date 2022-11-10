//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введи пятизначное число :");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num < 10000 || num > 99999)
// {
//     Console.WriteLine("Это не пятизначное число, введи ПЯТИЗНАЧНОЕ число : ");
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num2 > 9999 && num2 < 100000)
//     {
//         num += num2;
//     }
// }
// if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
// {
//     Console.WriteLine("Это палиндром");
// }
// else
// {
//     Console.WriteLine("Это не палиндром");
// }


// //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double DistanceBetweenPoints(double X1, double X2, double Y1, double Y2, double Z1, double Z2)
// {
// double distance = 0;
// {
// distance = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));
// Console.WriteLine(distance);
// }
// return distance;
// }
// Console.Write("Введите координату X1 ");
// double X1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X2 ");
// double X2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y1 ");
// double Y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y2 ");
// double Y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z1 ");
// double Z1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Z2 ");
// double Z2 = Convert.ToDouble(Console.ReadLine());
// double distance = DistanceBetweenPoints(X1,X2,Y1,Y2,Z1,Z2);

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N");

int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i * i} ");
}