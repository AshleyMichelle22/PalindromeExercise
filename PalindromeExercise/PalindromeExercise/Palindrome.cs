using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise //brought in to using on Unit test *
{
    public class Palindrome
    {
        // create a method to test later
        //class  type    Name     parameter of string
        public bool IsAPalindrome(string word)//string is a collection of characters can be an Array
        {            //^ Method

            // reverse the word-  Hello = olleH, Hello length is 5, lst index is 4 bc array strt at 0
            //store reversed word in a variable
            var reversed = "";


                      // word ^ book has 5 letter(array starts at 0, length index(array) would be at index 4 of array, why its word.length -1)
           for (int i = word.Length - 1; i >= 0; i--) 
            {                          //(for)^ keep looping until i is no longer greater then or = to 0.
                reversed += word[i];// word at index i-[i]
             //reversed = reveresd + word[i]
            }

            //compare the orig with the reversed
            if (reversed == word)
            {
                return true;
            }
            else
            { 
              return false;
            }
           //retrn if same on not
        
        }








    }
}
