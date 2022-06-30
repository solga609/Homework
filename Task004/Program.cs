// Задача 14: Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int num1=a;
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int num2=b;
        Console.WriteLine("Введите третье число: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int num3=c;
    int res = num1/num2;
    int res2 = num1/num3;
Console.WriteLine($" Число {num1} делённое на первое =  {res}");
 Console.WriteLine($"Число {num1} делённое на второе = {res2}");
  
    if(res==num1/num2 && res2==num1/num3){
        Console.WriteLine($"Число {num1} кратно:  {num2} , {num3}");
    }
     else if( num1%num2==0 ) 
    {
        Console.WriteLine($"Число не кратное {num2}, {num3}");
    }
   
    }

}
