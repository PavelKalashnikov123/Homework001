Console.WriteLine("Введите 3 числа:");
int number0 = Convert.ToInt32(Console.ReadLine());
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number0;

if (number1 > max)
{
    max = number1;
}

if (number2 > max)
{
max = number2;
}

Console.WriteLine("Наибольшее из введённых чисел " + max);
