using System;

string userInput;
do
{
    Console.WriteLine("Karra jadval");
    int number = 1 ;
    while (number <= 9)
    {
        int multiplyer = 1;
        while(multiplyer <= 9)
        {
            Console.WriteLine(multiplyer * number);
            multiplyer++;
        }

       Console.WriteLine("number: " + number);
        number++;

    }
    Console.WriteLine("Do you want continue? (y -> n)");
    userInput = Console.ReadLine();
}
while(userInput == "y");