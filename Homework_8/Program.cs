//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N в обратном порядке.


Console.Write("Введите число с которого будет идти обратный: ");
int a = Convert.ToInt32(Console.ReadLine());
int NaturalNumber(int num)
{
    if (num != 0)
    {
        Console.Write($"{num:d} ");
        NaturalNumber(num-1);
    }
    return num;
}
NaturalNumber(a);