Console.Write("Ввдите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "сергей")
{
    Console.WriteLine("Чего изволите мой Господин! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}