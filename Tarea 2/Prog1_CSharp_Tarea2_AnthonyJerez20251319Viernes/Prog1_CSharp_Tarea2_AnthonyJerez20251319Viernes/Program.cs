using System;

// Anthony Jerez (2025-1319)
// using top level statements
// In order to debug the code, please use .NET 9.0

Console.WriteLine("Let´s check if the number is even or odd");

bool active = true;
int chosenumber = 0;
int option = 0;

    while (active == true)
    {
    
        Console.WriteLine("Write the number");
    try
    {
       chosenumber  = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("User, please write a number");
        continue;
    }
        
        if (chosenumber % 2 == 0)
        {
            Console.WriteLine($"{chosenumber} is an even number");
        }
        else
    {
        Console.WriteLine($"{chosenumber} is an odd number");
    }

        Console.WriteLine("Want to continue?");
        Console.WriteLine("Press Any Key to continue/ Press 0 to exit");
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {

        Console.WriteLine("Let´s Continue Then");
        continue;
    }
       

        if (option == 0)
        {
            active = false;
        }
        else
        {
        Console.WriteLine("Let´s Continue Then");
        }
    } 


    Console.WriteLine("Thank you for using this app");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
