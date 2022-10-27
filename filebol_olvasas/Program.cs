// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;

/*
string text = "Ennek a szovegnek kellene megjelennie!";  
File.WriteAllText("proba.txt", text); 

try {
    string readText = File.ReadAllText("proba.txt");
    Console.WriteLine(readText);
}
catch(FileNotFoundException e) { Console.WriteLine("error"); } */

DateTime rendszerido = DateTime.Now;
using (StreamWriter sw = File.AppendText("proba.txt"))
{
    
    for (int i = 0; i < 100000; i++)
    {
        Random r = new Random();
        int rInt = r.Next(200000, 5500000);
        sw.WriteLine(rInt.ToString());
    }
}
/*
DateTime rendszerido = DateTime.Now;
string readText = File.ReadAllText("proba.txt");

DateTime rendszerido2 = DateTime.Now;
var eredmeny = rendszerido2 - rendszerido;
Console.WriteLine(eredmeny.ToString()); */
var fizetes = new List<double>();


using (StreamReader sr = new StreamReader("proba.txt"))
{
    
    string line;

    //var fizetes = new List<string>();
    while (!sr.EndOfStream)
    {
        line = sr.ReadLine();
        fizetes.Add(int.Parse(line));
    }
    sr.Close();
    
}


for (int k = 0; k < fizetes.Count; k++)
{
    fizetes[k] = fizetes[k] * 1.1;
}


using (StreamWriter sw = File.AppendText("emeles.txt"))
{
    for (int i = 0; i < fizetes.Count; i++)
    {
        sw.WriteLine(i.ToString());
    }
}

DateTime rendszerido2 = DateTime.Now;
var eredmeny = rendszerido2 - rendszerido;
Console.WriteLine(eredmeny.ToString());

Console.WriteLine("Hello, World!");
