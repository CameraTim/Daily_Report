using System;

class Daily
{
    static void Main()
    {
        // Using \n to add a line break
        Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
        Console.WriteLine("What is your name?");
        // Applying a user input to a string
        string studentName = Console.ReadLine();
        Console.WriteLine("Hello " + studentName + "! What course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("What page number of " + courseName + " are you on?");
        string pageNumber = Console.ReadLine();
        // Converting a string value assumed to be a number to an integer data type
        int pageNumInt = Convert.ToInt32(pageNumber);
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        string helpInput = Console.ReadLine();
        // Converting to Boolean
        bool helpChange = Convert.ToBoolean(helpInput);
        Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");
        string goodTimes = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hoursInput = Console.ReadLine();
        // Converting to a byte data type
        byte hoursStudy = Convert.ToByte(hoursInput);
        Console.WriteLine("Thank you for all the answers.  An Instructor will respond to this shortly.  Have a great day!");
        Console.ReadLine();
    }
}