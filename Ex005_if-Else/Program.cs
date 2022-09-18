Console.WriteLine("Напишите ваше имя!");
string name = Console.ReadLine();
if (name.ToLower() == "рита")
{
    Console.WriteLine("Гантер так ждал тебя, Рита");
}
else
{
    Console.Write("Опять ты - ");
    Console.WriteLine(name);
}