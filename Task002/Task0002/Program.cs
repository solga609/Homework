// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int rndNum = new Random(). Next(10, 100000);
Console.WriteLine($"Вывести третью цифру случайного числа из отрезка Next => {rndNum}");

int n1 = rndNum; 
Console.Write($"Третья цифра случайного числа => ");
if(n1  > 100 && n1 < 999)
{
Console.WriteLine(n1 % 10);
}

else if (n1>1000 && n1<9999){
    Console.WriteLine((n1 / 10) % 10 );
}
else if(n1>10000 && n1<99999){
    Console.WriteLine((n1 / 100) % 10);
}
 else if (n1 < 99) {Console.Write($"Третьей цифры нет");
}

