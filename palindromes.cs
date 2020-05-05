using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{

  public static void Main()
  {
    Console.WriteLine("Enter a word or number and I'll tell you if it's a palindrome!!");
    string userInput = Console.ReadLine();

    // if (Regex.IsMatch(userInput, @"^\d+$"))
    // {
    //   int userInt = int.Parse(userInput);
    //   bool isPalindrome = IntCheck(userInt);

    //   if (isPalindrome)
    //   {
    //     Console.WriteLine("This is a palindrome!");
    //   }
    //   else
    //   {
    //     Console.WriteLine("Not a palindrome");
    //   }

    // }

    bool isPalindrome = StringCheck(userInput);

    if (isPalindrome)
    {
      Console.WriteLine("This is a palindrome!");
    }
    else
    {
      Console.WriteLine("Not a palindrome!");
    }

  }

  public static Boolean StringCheck(string inputString)
  {
    bool isPal;

    int len = inputString.Length;



    string newString = "";

    for (int i = 0; i < inputString.Length; i++)
    {
      newString = newString.Insert(0, inputString[i].ToString());
    }

    Console.WriteLine(newString);

    if (newString == inputString)
    {
      isPal = true;
    }
    else
    {
      isPal = false;
    }

    return isPal;



  }

  // public static Boolean IntCheck(int inputInt)
  // {
  //   bool ispal;

  // }
}