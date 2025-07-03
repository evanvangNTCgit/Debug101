// The message property of this exception is readonly. Meaning a custom message propery must be set when instantiating the object.
/*
ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
throw invalidArgumentException;
throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");
*/


// You should throw an exception when the method cannot complete there intended purpose.
// Also use the most specific exception to showcase the error conditon (divide by zero exception when your dividing by zero)

/*************
THINGS TO AVOID

    Do not use exceptions for changing the flow of a program... USE IT TO REPORT AND/OR HANDLE ERROR CONDITIONS
    Exceptions shouldn't be returned as a return value or parameter instead of being thrown
    Dont create exceptions that can only be thrown in debug mode but not release mode. 
    Use Debug.Assert for runtime errors in development

    int age = -5;

    // Assert that age must be non-negative and above zero.
    Debug.Assert(age >= 0, "Age cannot be negative");

    Console.WriteLine("Program continues...");
**************/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}