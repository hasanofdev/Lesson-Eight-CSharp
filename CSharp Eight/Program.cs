using System;
using System.Text;
using Dictionary;

namespace CSharp_Eight;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        MyDictionary dictionary = new MyDictionary();

        Console.WriteLine(dictionary["Animal"]);
        Console.WriteLine(dictionary["Bird"]);
        Console.WriteLine(dictionary["Sweet"]);
        Console.WriteLine(dictionary["Insect"]);   
    }
}