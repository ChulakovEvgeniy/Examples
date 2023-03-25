Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // добавка ToLover() позволяет автоматически устранить ошибку в ведение имени маша разного регистра букв
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}