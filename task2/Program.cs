// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int[] InputArgs(string str)
{
    int[] input = new int[2];
    string text;
    newTry:
    Console.Write(str);
    text = Console.ReadLine();
    string[] split = text.Split(' ');
    for (int i = 0; i <= 1; i++)
    {
        if (!(int.TryParse(split[i], out input[i])) || split.Length !=2 || Convert.ToInt32(input[i]) <0)
        {   
            System.Console.WriteLine("Введены некорректные данные, повторите ввод");
            goto newTry;
        }                     
    }
    return input;
}

int FuncAck(int m, int n)
{
    while (m!=0)
    {
        if (n==0)
        {
            n=1;
        }
        else 
        {
            n = FuncAck(m, n - 1);
        }
        m =  m - 1;
    }
    return n + 1;
}

int[] argAck = InputArgs("Введи 2 натуральных числа для функции Аккермана A(m,n) (два числа через пробел): ");
System.Console.WriteLine($"Результат функции Аккермана A({argAck[0]},{argAck[1]}) = {FuncAck(argAck[0],argAck[1])}");