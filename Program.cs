using System;
string userInput;
do
{
    Console.WriteLine("Karra jadval");
    int number;
    int lastNumber;
    Console.Write("istalgan karra sonini kiriting : ");
    string inputNumber = Console.ReadLine();
    number = Convert.ToInt32(inputNumber);
    Console.Write("karras soni sechagacha davom etsin? : ");
    string inputLast = Console.ReadLine();
    lastNumber = Convert.ToInt32(inputLast);
    while (number <= lastNumber)
    {
        Console.WriteLine(number + " karra jadvali :");
        Console.WriteLine($"1 x {number} = {number * 1}");
        Console.WriteLine($"2 x {number} = {number * 2}");
        Console.WriteLine($"3 x {number} = {number * 3}");
        Console.WriteLine($"4 x {number} = {number * 4}");
        Console.WriteLine($"5 x {number} = {number * 5}");
        Console.WriteLine($"6 x {number} = {number * 6}");
        Console.WriteLine($"7 x {number} = {number * 7}");
        Console.WriteLine($"8 x {number} = {number * 8}");
        Console.WriteLine($"9 x {number} = {number * 9}");
        number++;
    }
    Console.WriteLine("Do you want continue? (yes -> no)");
    userInput = Console.ReadLine();
}
while(userInput == "yes");

