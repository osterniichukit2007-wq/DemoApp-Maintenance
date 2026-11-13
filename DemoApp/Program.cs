using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть ваше ім'я: ");
string userName = Console.ReadLine()?.Trim() ?? "";

Console.WriteLine($"Вітаю {userName}!");