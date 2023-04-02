using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("palindrome", false)]
        [InlineData("kayak", true)]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Nina", false)]
        [InlineData("Jonah", false)]
        [InlineData("Veronica", false)]
        [InlineData("Chika", false)]
        [InlineData("Tina", false)]
        [InlineData("Jonathan", false)]
        [InlineData("Peter", false)]
        [InlineData("Benjamin", false)]
        [InlineData("Ese", true)]

        public void IsAPalindromeTester(string word, bool expected)
        {
            //Arrange (skip step if method is static, so no need to create an instance)
            WordSmith tester = new WordSmith();

            //Act (call the method)
            var actual = tester.IsAPalindrome(word);

            //Assert (verify)
            Assert.Equal(expected, actual);
        }
    }
}
