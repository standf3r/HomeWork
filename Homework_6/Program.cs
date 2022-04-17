//Задача 58. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строки с наименьшей суммой элементов




int InputExamNumber() 
{
    while (true){
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number)){
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}

void PrintArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i, j] = new Random().Next(1, 10);}
    }
}

int NumMinSummRow(int[,] matr) {
    int position=1;
    int minsumm=0;
    for (int j = 0; j < matr.GetLength(1); j++){
            minsumm += matr[0, j];
        }
    for (int i = 1; i < matr.GetLength(0); i++){
        int summ=0;
        for (int j = 0; j < matr.GetLength(1); j++){
            summ += matr[i, j];
        }
        if (summ<minsumm) {
            minsumm=summ;
            position=i+1;
        }
    }
    return position;
}
Console.WriteLine("количество строк: ");
int m = InputExamNumber();
Console.WriteLine("количество столбцов: ");
int n = InputExamNumber();
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Задан массив");
PrintArray(matrix);
Console.WriteLine($"Строка с наименьшей суммой: {NumMinSummRow(matrix)}");
