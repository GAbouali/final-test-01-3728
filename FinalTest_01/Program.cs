// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->
//---------------------------------------------------------------------



//                                " Code Driver "
Console.WriteLine("enter the text: ");             // print the text from user.
string? phrase = Console.ReadLine() ?? "0";       //read the inputs as a string.


//                                 " methods "
//method to form the original array.
string[] CreatOrgArray(string phrase)
{
    string[] words = phrase.Split(' ');  // split the text according to spaces.
    //print the original array.
    Console.Write("the original array : [\"");
    for (int i = 0; i < words.Length - 1; i++)
    {
        Console.Write(words[i] + "\",\"");
    }
    Console.WriteLine(words[words.Length - 1] + "\"]");
    // return the original array.
    return words;
}

