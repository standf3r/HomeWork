// Задача 62. Заполнение массива спиралью

Console.Write("Введите размерность: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
    array[i,j] = temp;
    if (i <= j + 1 && i + j < n - 1)
    ++j;
    else if (i< j && i + j >= n - 1)
    ++i;
    else if(i >= j && i + j > n - 1)
    --j;
    else
    --i;
    ++temp;
}

for(int x = 0; x < array.GetLength(0); x++)
{
    for (int s = 0; s < array.GetLength(1); s++)
    {
        Console.Write( $"{array[x,s]:d3}");
    }
    Console.WriteLine();
}
Console.WriteLine();