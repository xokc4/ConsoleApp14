using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("напишите задание от 1 до 4");
            switch (Console.ReadLine())
            {
                case "1":
                    SedOne();
                    break;
                case "2":
                    SedTWO();
                    break;
                case "3":
                    SedThri();
                    break;
                case "4":
                    Sedfour();
                    break;
                default:
                    break;
            }
        }
    }
    public static void Sedfour()
    {
        string input = "Hello my world"; // Входная строка
        string reversedString = ReverseWords(input);

        Console.WriteLine(reversedString);
    }
    static string ReverseWords(string input)
    {
        // Разделение строки на слова по пробелам
        string[] words = input.Split(' ');

        // Создание новой строки для обратных слов
        string reversedString = "";

        // Проход через массив слов в обратном порядке
        for (int i = words.Length - 1; i >= 0; i--)
        {
            // Добавление слова в обратном порядке к строке
            reversedString += words[i];

            // Если это не последнее слово, добавляем пробел
            if (i > 0)
            {
                reversedString += " ";
            }
        }

        return reversedString;
    }
    public static void SedThri()
    {
        string input = "шалаш"; // Входная строка

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("Да, это палиндром.");
        }
        else
        {
            Console.WriteLine("Нет, это не палиндром.");
        }
    }
    static bool IsPalindrome(string input)
    {
        // Преобразуем строку к нижнему регистру для удобства сравнения
        input = input.ToLower();

        // Проходимся от начала и от конца строки к середине, сравнивая символы
        for (int i = 0, j = input.Length - 1; i < j; i++, j--)
        {
            // Если символы не совпадают, строка не является палиндромом
            if (input[i] != input[j])
            {
                return false;
            }
        }

        // Если прошли все проверки, строка является палиндромом
        return true;
    }
    public static void SedTWO()
    {
        string input = "aBcD1ef!-"; // Входная строка

        string result = ConvertToUpperToLower(input);

        Console.WriteLine(result); // Вывод результата
    }
    static string ConvertToUpperToLower(string input)
    {
        char[] charArray = input.ToCharArray(); // Преобразуем строку в массив символов

        // Проходим по всем символам в массиве
        for (int i = 0; i < charArray.Length; i++)
        {
            // Проверяем, является ли текущий символ заглавной буквой
            if (char.IsUpper(charArray[i]))
            {
                // Заменяем текущий символ на его строчный эквивалент
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        // Формируем строку из массива символов и возвращаем её
        return new string(charArray);
    }
    public static void SedOne()
    {
        // Задаем двумерный массив символов
        char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
        };

        // Создаем строку из символов массива
        string result = ConvertCharArrayToString(charArray);

        // Выводим полученную строку
        Console.WriteLine(result);
    }
    static string ConvertCharArrayToString(char[,] array)
    {
        int rows = array.GetLength(0); // Количество строк
        int cols = array.GetLength(1); // Количество столбцов

        // Создаем объект StringBuilder для построения строки
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        // Проходим по всем элементам массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Добавляем символ в StringBuilder
                sb.Append(array[i, j]);
            }
        }

        // Возвращаем полученную строку
        return sb.ToString();
    }

}