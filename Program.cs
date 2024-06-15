using System;

string userInput;
do
{
    int input = 0;
    while(input <= 9)
    {
        Console.WriteLine($"9 x {input} = {input * 9}");
        input++;
    }
    Console.WriteLine("Do you want continue? (y -> n)");
    userInput = Console.ReadLine();
}
while(userInput == "y");