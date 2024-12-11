using System;
using System.Collections;

int values = 0;
int[] rightlist = new int [7];
int[] leftlist = new int[7];
int[] distance = new int[7];
int sumdistance = 0;



Console.WriteLine("Let me find out the diffrences");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Enter right list ");

while (values != 6)
{
    values++;
    Console.Write($"Enter {values} Distance: ");
    leftlist[values]= int.Parse(Console.ReadLine());

}

values = 0;
Console.ForegroundColor= ConsoleColor.Green;
Console.WriteLine("Enter left list ");
while (values != 6)
{
    values++;
    Console.Write($"Enter {values} Distance: ");
    rightlist[values] = int.Parse(Console.ReadLine());

}
Console.ForegroundColor = ConsoleColor.White;
values = 0;
Array.Sort(leftlist);
Array.Sort(rightlist);
Console.WriteLine("");
Console.WriteLine("Sorting and calculating the distance");
Console.WriteLine();
while (values != 6)
{
    values++;
    distance[values] = leftlist[values] > rightlist[values] ? leftlist[values] - rightlist[values] : rightlist[values] - leftlist[values];
    Console.WriteLine("Left list       Right list          Distance");
    Console.WriteLine($"{leftlist[values],8}{rightlist[values],17}          {distance[values],9}");
    sumdistance = sumdistance + distance[values];  
}

Console.WriteLine("");

Console.WriteLine($"Full distance:  {sumdistance}");
Console.ForegroundColor = ConsoleColor.White;
