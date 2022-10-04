// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if ((a>b) && (a>c))
{
 Console.WriteLine("{0} max",a);   
}
if ((b>a)&& (b>c))
{
Console.WriteLine("{0} max",b);
}
if ((c>a) && (c>b))
{
 Console.WriteLine("{0} max",c);   
}
else if ((c==a) && (b==c) && (a==b))
{
 Console.WriteLine("Числа равны");    
}