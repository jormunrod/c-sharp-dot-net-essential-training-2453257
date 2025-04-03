// C# code​​​​​​‌‌​‌​​​‌​​​‌‌‌​‌​​‌‌‌‌‌‌‌ below
using System;

// Write your answer here, and then test your code.
// Don't change the structure of the Answer class.
public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
    public  static Boolean ShowExpectedResult = false;
    public  static Boolean ShowHints = false;

    public static string FormatDateTime(DateTime the_date) {
        // Your code goes here
        string year = the_date.Year.ToString();
        string month = the_date.Month.ToString();
        string day = the_date.Day.ToString();

        string[] data = {year, month, day};

        string output = String.Join("--", data);
        
        return output;
    }

    public static string FormatJoinStrings(string[] strs) {
        string output = String.Join(".", strs);
        return output.ToUpper();
    }

}
