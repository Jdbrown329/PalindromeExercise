using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar",true)]
        [InlineData("kayak",true)]
        [InlineData("wow",true)]
        [InlineData("dog",false)]
        public void Test1(string word,bool expected)
        {
            var testWord = new WordSmith();

            var actual= testWord.IsAPalindrome(word);

            Assert.Equal(expected, actual); 

        }
    }
}
