int i = 1;
bool n = true;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + number);
while (i <= number)
{
 if (i % 2 != 1)
 {
    Console.Write(i + ", ");
    n = false;
 }
 i++;
}

if (n)
{
 Console.WriteLine("Нет чётных чисел!");
}