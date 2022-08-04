//Дан текст. В тексте нужно все пробелы заменить черточками,
//а маленькие буквы "к" заменить на большие буквы "К"
//а большие "С" заменить на маленькие "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послала вместо нашего милого Венценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);

//Вывод таблицы умножения на экран

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <=10; j++)
    {
        Console.WriteLine($" {i} x {j} = {i * j} ");
    }
    Console.WriteLine();
}
// Методы: Вид 2
//void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method2(msg: "Текст", count: 4);
//Method2(count: 4, msg: "новый Текст");

// Метод Вид 3

//int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

// Метод Вид 4

//string Method4(int count, string text);
{
        int i = 0;
        string result = String.Empty;
    
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "z");

//string Method41(int count, string text);
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
//string res = Method41(10, "v");
//Console.WriteLine(res);
