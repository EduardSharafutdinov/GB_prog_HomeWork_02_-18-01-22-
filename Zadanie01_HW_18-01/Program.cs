// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Ввдите номер дня недели от 1 до 7, для проверки выходного дня: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 7) Console.WriteLine("Интересно, но в неделе только 7 дней. Давайте попробуем еще раз! Нужно будет ввести цифру от 1 до 7.");

if (8 > numberA) if (numberA > 5) 
{
    Console.WriteLine("Да! Это выходной день!");
}
if (6 > numberA) if (numberA > 0)
{
    Console.WriteLine("Этот день недели, является будним!");
}