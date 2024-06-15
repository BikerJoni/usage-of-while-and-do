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
        Console.Write($"1 x {number} = {number * 1} ");
        Console.Write($"2 x {number} = {number * 2} ");
        Console.Write($"3 x {number} = {number * 3} ");
        Console.Write($"4 x {number} = {number * 4} ");
        Console.Write($"5 x {number} = {number * 5} ");
        Console.Write($"6 x {number} = {number * 6} ");
        Console.Write($"7 x {number} = {number * 7} ");
        Console.Write($"8 x {number} = {number * 8} ");
        Console.Write($"9 x {number} = {number * 9} "); 
        number++;
        
    }
    Console.WriteLine("Do you want continue? (yes -> no)");
    userInput = Console.ReadLine();
}
while(userInput == "yes");

