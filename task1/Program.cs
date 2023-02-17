// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int[] InputInterval(string str)
{
    int[] input = new int[2];
    string text;
    newTry:
    Console.Write(str);
    text = Console.ReadLine();
    string[] split = text.Split(' ');
    for (int i = 0; i <= 1; i++)
    {
        if (!(int.TryParse(split[i], out input[i])) || split.Length !=2 || Convert.ToInt32(input[i]) <=0)
        {   
            System.Console.WriteLine("Введены некорректные данные, повторите ввод");
            goto newTry;
        }                     
    }
    if (Convert.ToInt32(input[0])>Convert.ToInt32(input[1]))
    {
        System.Console.WriteLine("Начало интервала (M) не должно быть больше конца интервала (N)");
        goto newTry;
    }
    return input;
}

int RecursionSum(int number1, int number2)
{
    if (number1 == number2)
    {
        return number2;
    }
    else 
    {
        return number1 + RecursionSum(number1 + 1, number2);
    }
}

int[] interval = InputInterval("Введи интервал натуральных чисел от M до N (два числа через пробел): ");
System.Console.WriteLine($"Сумма чисел от {interval[0]} до {interval[1]} : {RecursionSum(interval[0],interval[1])}");