// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {num} -> {num*num} ");


// 1. Напишите программу, которая принимает на вход трехзначное числои на выходе показывает **последнюю** цифру этого числа.

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num < 1000)
// {
//     System.Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else
// {
//     System.Console.WriteLine("You input not three-digit number");
// }

// 2. Решите задачу

// System.Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = -n;
// while (count <=n)
// System.Console.Write (count++);

// 3. Решите вторую задачу

// System.Console.WriteLine("Введите число: ");
// int num=Convert.ToInt32(System.Console.ReadLine());
// int i= -1*num;
// while (i<=num)
// {
//     System.Console.WriteLine(i++);
// }


// 4. Решение домашнего задания

// Console.WriteLine("чтобы узнать какое число большее, а какое меньшее.");
// Console.WriteLine("Введите два числа.");
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine("Число " + num1 + " большее");
//     Console.Write("Число " + num2 + " меньшее");
// }
// else if (num1 == num2)
// {
//     Console.WriteLine("Число " + num1 + " равно числу " + num2);
// }
// else
// {
//     Console.WriteLine("Число " + num2 + " большее");
//     Console.Write("Число " + num1 + " меньшее");
// }

// 5. Вторая задача

// Console.WriteLine("Введите три числа, и узнайте, ");
// Console.WriteLine("какое из них имеет максимальное значение.");
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());
// int maxnum = 0;
// if (num1 > maxnum) maxnum = num1;
// if (num2 > maxnum) maxnum = num2;
// if (num3 > maxnum) maxnum = num3;
// Console.Write("Максимальное значение имеет число " + maxnum);

// 6. Третья задача

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int remain = num % 2;
// if (remain == 0)
// {
//     Console.WriteLine("Число " + num + " четное?");
//     Console.WriteLine("Да!");
// }
// else
// {
//     Console.WriteLine("Число " + num + " четное?");
//     Console.WriteLine("Нет!");
// }

// 7. Четрвертая задача

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}