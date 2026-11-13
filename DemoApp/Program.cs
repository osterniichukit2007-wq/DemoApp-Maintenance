using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть ваше ім'я: ");
string userName = Console.ReadLine()?.Trim() ?? "";

Console.WriteLine($"Вітаю {userName}!");

Console.Write("Введіть ваш вік: ");
int age;
while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 150)
{
    Console.Write("Некоректне значення. Введіть вік цілим числом від 0 до 150: ");
}

string status = age >= 18 ? "повнолітній(-я)" : "неповнолітній(-я)";
Console.WriteLine($"Користувач: {userName}, вік: {age} — {status}.");