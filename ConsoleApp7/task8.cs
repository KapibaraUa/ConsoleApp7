using System;

namespace ConsoleApp7;

public class VowelsCountTask
{
    public static void Run()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine() ?? String.Empty;

        int vowelsCount = CountVowels(sentence);

        Console.WriteLine($"Количество гласных букв в предложении: {vowelsCount}");
    }

    static int CountVowels(string text)
    {
        string vowels = "aeiouyAEIOUYаеёиоуыэюяіїєАЕЁИОУЫЭЮЯІЇЄ";
        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (vowels.IndexOf(text[i]) != -1)
            {
                count++;
            }
        }

        return count;
    }
}