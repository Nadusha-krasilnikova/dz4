// дано число из отрезка(10,99).Показать наибольшую цифру числа
int a=new Random( ).Next(10,99);
Console.WriteLine(a);
int resultB=(a/10) % 10;
int resultC=a % 10;
int max=resultB;
if (resultB>max) max=resultB;
if (resultC>max) max=resultC;
Console.Write("максимальная цифра числа=");
Console.Write(max);
