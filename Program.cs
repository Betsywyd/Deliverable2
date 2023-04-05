// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name + ".Do you want to do the COIN FLIP CHALLENGE? Yes/No");
string result = Console.ReadLine().ToUpper();
int score = 0;
if (result == "NO")
{
    Console.WriteLine("You are a coward " + name);
}
else if (result =="YES")
{   for (int i = 0; i < 5; i++) {
        Random rnd = new Random();
        int num = rnd.Next(0, 2);
        Console.WriteLine(num);
        Console.WriteLine("Heads or Tails?");
        string guess = Console.ReadLine().ToUpper();
        if ((guess == "HEADS" && num == 1) || (guess == "TAILS" && num == 0))
        {
            Console.WriteLine("Correct!");
            score++;

        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
    Console.WriteLine("Thank you "+name+". You got a score of " + score + "!");
}


