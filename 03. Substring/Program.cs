string toRemove = Console.ReadLine();
string text = Console.ReadLine();

while (text.Contains(toRemove))
{
    text = text.Replace(toRemove, "");
}

Console.WriteLine(text);