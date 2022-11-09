
// ========================================== start =============================================

// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int MultiNum(int numA, int numB)
{
    int result = numA;
    for (int i = 2; i <= numB; i++)
    {
        result = result * numA;
    }
    if (numB == 0 & numA != 0)
    {
        result = 1;
    }
    return result;
}

Console.WriteLine(MultiNum(numberA, numberB));
*/

// ============================================= end =======================================

// ========================================== start =============================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int remainderNum = num % 10;
        sum += remainderNum;
        num = (num - remainderNum) / 10;
    }
    return sum;
}
int result = SumNum(number);
Console.WriteLine(result);
*/

// ============================================= end =======================================

// ========================================== start =============================================

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRandom(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArrayRandom(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]");
}
PrintArrayRandom(CreateArrayRandom(number));

// ============================================= end =======================================
