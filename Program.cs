using Microsoft.VisualBasic;
using System;
using System.Globalization;

public class Class1
{

    static void Main(string[] args)
    {
        //Console output date-message: "01.05.2008 08:30:52"
        var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
        Console.WriteLine(date1);
        //Console output basic date-message: "01.01.0001 00:00^00"
        var date2 = new DateTime();
        Console.WriteLine(date2);
        //Assignment varible value using DateTime methods
        var date3 = DateTime.Now;
        var date4 = DateTime.UtcNow;
        var date5 = DateTime.Today;
        Console.WriteLine(date3);
        Console.WriteLine(date4);
        Console.WriteLine(date5);
        //Example of converting sting to DateTime varible
        string mystring = "01/08/2004 04:30:32";
        DateTime date6 = DateTime.Parse(mystring);
        Console.WriteLine(date6);
        //Example of converting string, which was input by user, to DateTime varible
        string mystring2 = Console.ReadLine();
        DateTime date7;
        try
        {
            date7 = DateTime.Parse(mystring2);
            Console.WriteLine(date7);
        }
        catch
        {
            Console.WriteLine("warning");
        }
        //Example of converting DateTime to string varible
        var date8 = DateTime.Now;
        Console.WriteLine(date8.ToString());
        //Example using string DateTime varible
        Console.WriteLine(date8.ToString("F"));
        //Example using diffrent methods of DateTime and Calendar
        Console.WriteLine(date8.Year);
        Console.WriteLine(date8.DayOfWeek);
        Console.WriteLine(date8.DayOfYear);
        var greg = new System.Globalization.GregorianCalendar();
        Console.WriteLine(greg.CalendarType);

    }
}
