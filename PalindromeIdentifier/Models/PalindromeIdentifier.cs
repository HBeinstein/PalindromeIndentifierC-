using System;
using PalindromeCheck;
using System.Collections.Generic;

namespace project
{
  public class project
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word to see if it is a Palindrome: ");
      string userInput = Console.ReadLine();

      Palindrome palindromeInput = new Palindrome(userInput);
      string palindromeAnswer = palindromeInput.IsPalindromeString(userInput);
      Console.WriteLine(palindromeAnswer);
    }
  }
}