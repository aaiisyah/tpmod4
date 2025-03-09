// See https://aka.ms/new-console-template for more information
using System;
using tpmodul4_103022300116;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Samoja: " + KodePos.getKodePos("Samoja"));
    }
}
