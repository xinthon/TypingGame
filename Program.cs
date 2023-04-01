Console.WriteLine("Welcome to Typing Game!");
Console.WriteLine("Type the word and press Enter key.");
Console.WriteLine("Press Enter key to start the game.");
Console.ReadLine();

string[] words = { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape" };
Random random = new Random();
int index = random.Next(words.Length);
string word = words[index];

string input = "";
int score = 0;
DateTime startTime = DateTime.Now;

while (true)
{
    Console.Clear();
    Console.WriteLine("Score: {0}", score);
    Console.WriteLine("Time: {0:mm\\:ss}", DateTime.Now - startTime);
    Console.WriteLine("Type the word:");
    Console.WriteLine(word);
    input = Console.ReadLine();

    if (input.ToLower() == word.ToLower())
    {
        score++;
        index = random.Next(words.Length);
        word = words[index];
    }
    else if (input.ToLower() == "exit")
    {
        break;
    }
}

Console.WriteLine("Goodbye!");
