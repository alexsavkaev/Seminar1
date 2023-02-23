using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1)
    {
        //Console.WriteLine(end);
        return "1";
    }
    
    string s = PrintNumbers(end - 1) + ' ' + end.ToString();
    //Console.WriteLine(s);
    return (s);
}