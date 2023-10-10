// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
string input = Console.ReadLine();

if (input.Length >= 3)
{
    char thirdDigit = input[2];
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}