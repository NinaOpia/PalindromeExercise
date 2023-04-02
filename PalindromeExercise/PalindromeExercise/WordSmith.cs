using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}
      
        public bool IsAPalindrome(string word)
		{
			var reversed = ""; //This is the same thing as using string.Empty;

			for (var i = word.Length - 1; i >= 0; i--)
			{
				reversed += word.ToLower()[i];
			}

			if (reversed == word.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}
		}   
    }
}

