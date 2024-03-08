using System;
using System.Collections.Generic;
using System.Linq;

class PrimeMinister
{
    public string Name { get; set; }
    public int Year { get; set; }

    public PrimeMinister(string name, int year)
    {
        Name = name;
        Year = year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, PrimeMinister> primeMinisters = new Dictionary<int, PrimeMinister>
        {
            { 1998, new PrimeMinister("Atal Bihari Vajpayee", 1998) },
            { 2014, new PrimeMinister("Narendra Modi", 2014) },
            { 2004, new PrimeMinister("Manmohan Singh", 2004) }
        };

        //Prime Minister of 2004
       Console.WriteLine($"The Prime Minister of 2004 was: {primeMinisters[2004].Name}");
        

        // Add the current Prime Minister
        primeMinisters[2024] = new PrimeMinister("Narendra Modi", 2024);

        // Sort the dictionary by year
        var sortedPM = primeMinisters.OrderBy(pm => pm.Key);

        Console.WriteLine("\nPrime Ministers sorted by year:");
        foreach (var pm in sortedPM)
        {
            Console.WriteLine($"Year: {pm.Key}, Prime Minister: {pm.Value.Name}");
        }
    }
}