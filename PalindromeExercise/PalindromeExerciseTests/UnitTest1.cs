using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("madam", true)]
        [InlineData("baseball", false)]
        public void Test1(string word, bool expected)
        {
            var palindrome = new WordSmith();

            var actual = palindrome.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
