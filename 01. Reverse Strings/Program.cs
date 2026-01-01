string input;

while ((input = Console.ReadLine()) != "end")
{
    string reversed = new string(input.Reverse().ToArray());
    Console.WriteLine($"{input} = {reversed}");
}