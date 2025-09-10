using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine($"Number of letters: {sentence.Replace(" ", "").Length}");
    }
}