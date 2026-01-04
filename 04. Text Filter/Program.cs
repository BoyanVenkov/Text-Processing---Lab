string[] bannedWords = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries);

string text = Console.ReadLine();

foreach (string word in bannedWords)
{
    string censored = new string('*', word.Length);
    text = text.Replace(word, censored);
}

Console.WriteLine(text);