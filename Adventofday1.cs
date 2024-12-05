using System;
using System.Collections;

int values = 0;
int[] rightlist = new int [7];
int[] leftlist = new int[7];


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

while (values != 6)
{
    values++;
    Console.WriteLine($"{leftlist[values]}    {rightlist[values]}");
}
Console.ForegroundColor = ConsoleColor.White;
