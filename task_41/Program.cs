//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] EnteringNumbersByQuantity(int number)
{
    int[] arrayNumber = new int[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите число: ");
        arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arrayNumber;
}

int GetCountNumbersAboveZero(int[] arrayNumber)
{
    int countNumbersAboveZero = 0;
    for (int i = 0; i < arrayNumber.Length; i++)
    {
        if (arrayNumber[i] > 0)
        {
            countNumbersAboveZero++;
        }
    }

    return countNumbersAboveZero;
}

Console.Write("Введите количество чисел: ");
int countNumber = Convert.ToInt32(Console.ReadLine());
int[] arrayNumber = EnteringNumbersByQuantity(countNumber);
Console.WriteLine($"Чисел больше нуля: {GetCountNumbersAboveZero(arrayNumber)}");
