// В тексте нужно заменить все пробелы черточками, маленькие "к" большими, большие "В" маленькими
string text = "- Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = "qwerty"
//            012345
//s[3] //        r
//метод будет принимать строку и те символы которые нужно будет менять, старый символ на новый
//возвращаться также будет строка, поэтому string
string Replace(string text, char oldValue, char newValue)
//     замена     ||  текст||старый символ ||новый 
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)                            // пробегаем от нулевого символа до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}";// если текст совпал, то в result должны положить newValue
        else result = result + $"{text[i]}";                    // если текст не совпал, то в result должны положить текущий символ oldValue
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');                          //теперь меняем к на К
Console.WriteLine(newText);                                    //показываем результат
Console.WriteLine();
newText = Replace(newText, 'В', 'в');                          //теперь меняем к на К
Console.WriteLine(newText);  