using System;

namespace PalindromeCheck
{
  public class Palindrome
  {
    public string UserInput { get; set; }

    public Palindrome(string userInput)
    {
      UserInput = userInput;
    }

    public string IsPalindromeString(string userInput)
    {
      // string[] wordArray = string userInput;
      char[] wordArray = userInput.ToCharArray();
      Array.Reverse(wordArray);
      string reversedWord = String.Join("", wordArray);
      if (reversedWord == userInput)
    {
      return "sure is";
    }
    else
    {
      return "nope";
      }
    }  
  }
}