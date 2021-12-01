//Метод 1 ничего не принимает (никаких аргументов) и ничего не возвращает (void)

// void Method1()
// {
//     Console.WriteLine("Автор текста - ........");
// }
// Method1();

//Метод 2 - ничего не возвращает (void), но может принимать аргументы

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текст сообщения");

// void Method21 (string msg, int count)
// {
//     int i=0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Новый текст", count: 4);

//Метод 3 - что то возвращает (return), но никакие аргументы не принимает

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year=Method3();
// Console.WriteLine(year);

//Метод 4 - что-то принимает и что-то возвращает (return)

/* string Method4(int count, string text)
{
    // int i=0;
    // string result = String.Empty; //задано значение пустая строка, можно также ="";
    // while (i<count)
    // {
    //     result=result+text;
    //     i++;
    // }
    // return result;
    //}
    //string res=Method4(10, "asdf");//10 раз напечатает текст
    //Console.WriteLine(res);
    string result=String.Empty;//тоже что выше, только с использованием циклв for
    for (int i=0; i<count;i++)
    {
        result=result+text;
    }
    return result;
}

string res=Method4(10, "z");//10 раз напечатает текст
Console.WriteLine(res); */

//5. Вывод таблицы умножения на экран

for (int i=2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine(); //выводит пустую строку для разрывов страницы
}