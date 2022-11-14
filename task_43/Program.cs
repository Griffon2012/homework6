// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[] GetIntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] arrayPoints = new double[2];

    double x = (b2 - b1) / (k1 - k2);
    arrayPoints[0] = Math.Round(x, 2);

    double y = (k1 * arrayPoints[0]) + b1;
    arrayPoints[1] = Math.Round(y, 2);

    return arrayPoints;
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double[] arrayPoints = GetIntersectionPoint(b1, k1, b2, k2);

Console.WriteLine($"({arrayPoints[0]}; {arrayPoints[1]})");