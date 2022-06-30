// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Ввести номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0 && num < 8) {
if(num == 1) Console.WriteLine("Понедельник =>");
else if (num == 2) Console.WriteLine("Вторник =>");
else if (num == 3) Console.WriteLine("Среда =>");
else if (num == 4) Console.WriteLine("Четверг =>");
else if (num == 5) Console.WriteLine("Пятница =>");
 if (num == 6 ) Console.Write("Суббота =>") ;
else if (num == 7) Console.Write("Воскресенье =>");
}
if(num > 5) {
    Console.Write("Да");
}
 else if (num <= 5)  Console.Write("Нет");

