/*
Try-Catch: Consists of a try block followed by catch(s) clauses where that block is ran when the it catches the exception/eror 

Try-Finally: Consists of a try block followed by a finally block. Typically the finally block is ran when control leaves a try statement.

Try-Catch-Finally: Just a combination of the previous two
*/

try
{
    System.Console.WriteLine("Inside the Try block");

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("#:" + (i + 1));
    }
}
finally
{
    Console.WriteLine("Inside the finally block now!");
}