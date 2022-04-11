//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

System.Console.WriteLine("Введите число(а): ");
String numb = Console.ReadLine();
string[] Numbers = numb.Split(' ');
int[] ConvertNumbers = new int[Numbers.Length];
for (int i = 0; i < Numbers.Length; i++)
{
    ConvertNumbers[i] = Int32.Parse(Numbers[i]);
}




int GetCountOfPosNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
System.Console.Write("Чисел больше 0: ");
System.Console.WriteLine(GetCountOfPosNumbers(ConvertNumbers));
