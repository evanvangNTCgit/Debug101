/*

// So essentially it throw an error in the try then catches it HOWEVER before catch code block is ran... The finally block runs first.
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{
    // Step 5: the system transfers control to the first line of the catch code block
}

Try-Catch: Consists of a try block followed by catch(s) clauses where that block is ran when the it catches the exception/eror 

Try-Finally: Consists of a try block followed by a finally block. Typically the finally block is ran when control leaves a try statement.

Try-Catch-Finally: Just a combination of the previous two

Exceptions are represented as objects in cose meaning their an instance of a class. .NET Class library provides exception classes accessed in code like other .NET classes
An example of a .NET class used as an object in code is the random class Random random = new Random();
                                                                             ^ class            ^object
DIFFERENCES OF AN OBJECT AND CLASS: A class defines a type of object but not an object itself. The object is a concrete entity based on a class.

*/

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}