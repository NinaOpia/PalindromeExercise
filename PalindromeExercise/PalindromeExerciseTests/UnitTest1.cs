using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("Breeze", true)]
        [InlineData("Energy", true)]
        [InlineData("Palindrome", false)]
        [InlineData("technodrome", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange (skip step if method is static, so no need to create an instance)
            var tester = new WordSmith();

            //Act (call the method)
            var actual = tester.IsAPalindrome(word);


            //Assert (verify)
            Assert.Equal(expected, actual);
        }
    }
}
