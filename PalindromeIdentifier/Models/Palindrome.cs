namespace Palindrome
{
  public class Palindrome
  {
    public bool IsPalindromeString(string userInput)
    {
      string[] wordArray = string userInput;
      string reverseArray = Array.Reverse(wordArray);
      string reversedWord = String.Join("", reverseArray);
      if (reversedWord == userInput)
    {
      return true;
    }
      else
    {
      return false
      }
    }  
  }
}