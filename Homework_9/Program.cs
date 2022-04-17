//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int NaturalNumber(int m, int n)
{
    if (m < n){
        sum += m;
        NaturalNumber(m + 1, n);
        return sum + n;}
    else if (m > n){
        sum += n;
        NaturalNumber(m, n + 1);
        return sum + m;}
    else return 0;
}
Console.WriteLine($"\nCумму натуральных элементов в промежутке: {NaturalNumber(m, n):n0}\n");