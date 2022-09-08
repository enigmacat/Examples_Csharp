// Вид 1 ничего не возвращает и не принимает

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//===================================================================

// Вид 2 ничего не возвращает, но принимает аргументы 

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.Write(msg);
        i++;
    }
}

Method21("Текст ", 5);
Method21(count: 4, msg: "Новый текст ");

//=====================================================================

// Вид 3 что-то возвращают, но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//=====================================================================

// Вид 4 что-то принмают и что-то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "TEXT ");
// Console.WriteLine(res);

// Вид 41 Цикл "for"

// string Method41(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method41(10, "TExt ");
// Console.WriteLine(res);

// Вид 42 цикл "for" в цикле "for"

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}x{j}= {i * j}");
//     }
//     Console.WriteLine();
// }

//===================================================================
// ==== Работа стекстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими букуами "К",
// а маленькие "с" заменить большими "С".

string text = " - Я думаю, сказал князь, улыбаясь, - что, "
            + "ежели лбы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // e

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

//===============================================

// отсортировать массив от мин до макс значения элемента

int[] arr = { 5, 3, 7, 2, 8, 9, 4, 6, 1, 3, 7, 4, 5, 8, 5 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);