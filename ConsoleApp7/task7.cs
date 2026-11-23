using System;

namespace ConsoleApp7;

public class ReverseWordsTask
{
    public static void Run()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine() ?? String.Empty;

        string reversedSentence = ReverseWordsInSentence(sentence);

        Console.WriteLine("Результат:");
        Console.WriteLine(reversedSentence);
    }

    static string ReverseWordsInSentence(string text)
    {
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseWord(words[i]);
        }

        return String.Join(" ", words);
    }

    static string ReverseWord(string word)
    {
        char[] reversedChars = new char[word.Length];
        for (int i = 0; i < word.Length; i++)
        {
            reversedChars[i] = word[word.Length - 1 - i];
        }
        return new string(reversedChars);
    }
}