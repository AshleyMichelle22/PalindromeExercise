using System;
using Xunit;
using PalindromeExercise;  // * had to bring in using PalidromeExerciseTest/Palindrome tab to make method work!!

                   // Test method 
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bob", true )]// returns true bc racecar is palindrome- 1st
        [InlineData("babes", false)]// returns false bc hello can not be read front to back-2nd
        [InlineData("back", false)]
        //string type data/parameters
        // void- not returning anything
        // tells you tst pass or not-not returing value
        public void Mytest(string word, bool expected)
        {
            //arrange create new instance method of Palindome Class, to use IsAPalindrome/ wanting to test 'IsAPalindrome"
            var tester = new Palindrome();//*
            //act-- Call IsAPalidrome method
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
