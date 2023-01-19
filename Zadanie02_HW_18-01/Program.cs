// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите два числа для проверки");
Console.Write("Число №1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Число №2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = 0;

{
    if ((numberA / numberB) == numberB)
    {
        Console.WriteLine("Число №1 является квадратом числа №2");
    }
}
    if ((numberB / numberA) == numberA)
    {
        Console.WriteLine("Число №2 является квадратом числа №1");
    }

{
    if ((numberA / numberB) != numberB)
    {
        Console.WriteLine("Число №1  не является квадратом числа №2");
    }

    if ((numberB / numberA) != numberA)
    {
        Console.WriteLine("Число №2 не является квадратом числа №1");
    }
}
