using System;

class YourAgeAfterTenYears
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please input your birthday in format dd/mm/yyyy: "); //promitng message
        DateTime birthDate = DateTime.Parse(Console.ReadLine());                //takes the input of the user, and converts it into DateTime format
        DateTime today = DateTime.Today;                                        //takes the date today
        int age = today.Year - birthDate.Year;                                  //the three lines find exactly
        int months = today.Month - birthDate.Month;                             //how old are you, taken from today
        int days = today.Day - birthDate.Day;
        Console.WriteLine("You are {0} years ,{1} months, {2} days old"         //displays your age
                                                , age, months, days);
        today = today.AddYears(10);                                             //finds the date in ten years

        age = today.Year - birthDate.Year;                                      //calculates how old are you in ten years
        months = today.Month - birthDate.Month;
        days = today.Day - birthDate.Day;
        Console.WriteLine("You will be {0} years ,{1} months, {2} days old in ten years"  //displays the result
                                                , age, months, days);
        
    }
}
