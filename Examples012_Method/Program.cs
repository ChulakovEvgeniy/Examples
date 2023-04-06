//Метод которой ничего не принимает и ничего не возвращает, просто что сам
//по себе делает)
void Method1()
{
    System.Console.WriteLine("любой текст");
}

//Method1();


//Метод 2 - 

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

//Method2("Текст сообщения");
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", 4);

//3 Метод

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

//4 метод

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "GQ");
System.Console.WriteLine(res);