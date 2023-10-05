// 1. Первая задача

// Console.WriteLine("Введите трехзначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberS = Math.Abs(number).ToString();
// Console.WriteLine(numberS.Length == 3 ? 
// $"{number} -> {numberS[1]}" : "Вы ввели не трехзначное число");


// 2. Вторая задача

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? 
$"{number} -> {numberS[2]}" : $"{numberS} -> третьей цифры нет");

