// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int rndNum = new Random(). Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {rndNum} ");
int firstDigit = rndNum / 100;
int secondDigit = rndNum % 100;
int thirdDigit = secondDigit / 10;

 Console.WriteLine(thirdDigit);

