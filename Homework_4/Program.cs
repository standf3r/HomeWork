// Задача 49. Задайте двумерный массив. Найдите элементы у которых оба индекса нечетные, замените их элементы на квадраты. 

Console.Write("Введите параметр n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввкдите параметр k: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[n, k];

for (int u = 0; u < mass.GetLength(0); u++)
{
     Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[u,j] = new Random().Next(0,11);
        Console.Write(mass[u,j] + " ");
    }
}

Console.WriteLine();
for (int p = 0; p < mass.GetLength(0); p++)
{
     Console.WriteLine();
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (p % 2 == 1 && j % 2 == 1)
        {
            Console.Write(mass[p,j] * mass[p,j] + "\t");
        }
        else
        {
            Console.Write($"{mass[p,j]}" + "\t");
        }
    }
}