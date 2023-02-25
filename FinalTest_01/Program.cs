// Задача: 
//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> D
//------------------------------------------
//                                " Code Driver "

Console.WriteLine("enter the text: ");             // print the text from user.
string? phrase = Console.ReadLine() ?? "0";       //read the inputs as a string.
string[] str1 = CreatOrgArray(phrase);                  //call the method to print original array.
int ElementMaxLength=3;
ResultArray(str1,ElementMaxLength);                               //call the method to print second array.

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

// method to form the second array.
string[] ResultArray(string[] str1,int ElementMaxLength)
{
    string[] str2 = new string[str1.Length];     //creat the second array.
    Console.Write("the elements equal and less than 3 charachters are : [\"");
    for (int i = 0; i < str2.Length; i++)     //loop to check each element in the original array.
    {
        if (str1[i].Length <= ElementMaxLength)             //conditions of forming the second array.
        {
            str2[i] = str1[i];                             //giving a value for each element.
            Console.Write(str2[i] + "\",");
        }
    }
    Console.WriteLine("]");
    return str2;
}