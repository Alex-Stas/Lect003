// Метод 1
void Copyright()
{
    Console.WriteLine("All rights reserved");
}

Copyright();


// Метод 2
void Method2 (string message)
{
    Console.WriteLinne(message);
}
Method2 ("Text");
Method2 (message: "text"); // явно названные аргументы, если их нескольк, порядок уже не важен

// Метод 3

int Method3 ()
{
    return DateTime.Now.Year;
}

Method3 ();

