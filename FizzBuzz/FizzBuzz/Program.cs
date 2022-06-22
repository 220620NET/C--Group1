// The app asks the user to enter a number.

Console.WriteLine("Pick a number, please.");
string pickedNumber = Console.ReadLine();

// THE STRING MUST BE CONVERTED TO AN INT AT SOME POINT

// int newNum = Convert.ToInt32(pickedNumber);
int newNum = int.Parse(pickedNumber);

int theNum = newNum;

for(int i = 0; i < theNum; i++)
{
    // newNum increases by 1 each iteration after the first
   int finalNum = i;

   // The app will then print every number from 1 to whatever the user entered ...
   // Except if the number is divisible by 3, it prints 'fizz' instead ...
   if (finalNum % 3 == 0) 
   {
    Console.WriteLine("fizz ");
   }
   // OR if the number is divisible by 5, it prints 'buzz' instead
    else if (finalNum % 5 == 0) 
    {
        Console.WriteLine("buzz ");
    }

    // OR if the number is divisible by 3 and 5, it prints 'fizzbuzz' instead 

    else if (finalNum % 5 == 0 && finalNum % 3 == 0) 
    {
        Console.WriteLine("fizzbuzz ");
    }

    // if none of those conditions are met, this is where it prints the regular number

    else
    {
        Console.WriteLine(finalNum);
    }
}




