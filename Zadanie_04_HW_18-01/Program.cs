// Найти расстояние между точками в пространстве 2D/3D
Console.Write("В каком пространстве Вы хотите узнать расстояние между точками? для 2D - нажмите цифру 2, для 3D - нажмите цифру 3: ");
int variant = int.Parse(Console.ReadLine()!);

if (variant == 2)
{
    Console.Write("Введите координаты точки А, в плоскости 2D по оси-1: ");
    double x1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки А, в плоскости 2D по оси-2: ");
    double y1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки А, в плоскости 2D по оси-1: ");
    double x2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки В, в плоскости 2D по оси-2: ");
    double y2 = double.Parse(Console.ReadLine()!);
    double AB1 = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)));
        Console.WriteLine($"Расстояние между точками в плоскости 2D состовляет: {AB1} ");
}

if(variant == 3)
{
    Console.Write("Введите координаты точки А, в плоскости 3D по оси-1: ");
    double x1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки А, в плоскости 3D по оси-2: ");
    double y1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки А, в плоскости 3D по оси-3: ");
    double z1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки В, в плоскости 3D по оси-1: ");
    double x2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки В, в плоскости 3D по оси-2: ");
    double y2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координаты точки В, в плоскости 3D по оси-3: ");
    double z2 = double.Parse(Console.ReadLine()!);
    double AB2 = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1)));
    Console.WriteLine($"Расстояние между точками в плоскости 2D состовляет: {AB2} ");
}


else
{
    Console.Write("Ошибка! Запустите еще раз и выберете нужную плоскость!");
}
