// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
            
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
   
    return result;
}

double k1 = GetNumberFromConsole("Введите значение k1");
double b1 = GetNumberFromConsole("Введите значение b1");
double k2 = GetNumberFromConsole("Введите значение k2");
double b2 = GetNumberFromConsole("Введите значение b2");
double[] coordinates = GetIntersectionPoint(b1,k1,b2,k2);
Console.WriteLine($"Точка пересечения ({coordinates[0]}; {coordinates[1]})");