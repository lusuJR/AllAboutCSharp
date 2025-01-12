using System;

// Functions can provide default values for their parameters
void PrintWithPrefix(string thestr, string prefix="")
{
    Console.WriteLine($"{prefix} {thestr}");
}

// Test the default parameters
PrintWithPrefix("Hello Lusukama!");
PrintWithPrefix("Hello Lusukama!", ">: ");

// Call with named params
PrintWithPrefix(prefix: "% ", thestr: "Hello Lusukama!");
