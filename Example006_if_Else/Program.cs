// Код с личным приветствием


Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //Ввожу команду ToLower, чтобы все буквы были с маленькой
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
