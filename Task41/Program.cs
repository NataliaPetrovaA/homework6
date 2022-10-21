// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] RequestToEnterNumbers(int m)
{
    int[] massiv = new int[m];
    for (int i = 0; i < massiv.Length; i++)
    {
        int temp = 0;
        Console.WriteLine($"Введите число {i + 1}: ");
        temp = Convert.ToInt32(Console.ReadLine());
        massiv[i] = temp;
    }
    return massiv;
}

void PrintMassiv(int[] arr)
{
    Console.WriteLine("Введенные Вами числа");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int SumPositiv(int[] arr)
{
    int positiv = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiv++;
        }
    }
    return positiv;
}

int m = GetNumberFromConsole("Введите колличество чисел, m");
int[] Numbers = RequestToEnterNumbers(m);
PrintMassiv(Numbers);
SumPositiv(Numbers);
Console.WriteLine("из них положительных чисел: " + SumPositiv(Numbers));