# ITELEC2 – Week 1 Activity

**Name:** Erin Hannah Butial  
**Section:** 3.5 BSIT  
**Course:** ITELEC2 – Elective 2 (C# Language)

## Programs

### 1. Hello NTC
A basic C# console program that displays a greeting, my full name, section, and an application I would like to develop.

### 2. Student Profile
A console application demonstrating the use of variables, data types (`string`, `int`, `double`, `char`, and `bool`), and string interpolation.

### 3. Bill Splitter
A console application demonstrating integer division, the modulo operator, and explicit type casting by splitting a PHP 250 bill among four friends.

## What I Learned

### Compiler Errors

- **CS1002 – ; expected:** This error occurs when a required semicolon is missing from a C# statement.
- **CS0103 – The name does not exist in the current context:** This error occurred when I changed `Console` to `console`, demonstrating that C# is case-sensitive.

### Integer Division

My prediction for `250 / 4` using integer values was **62**, and the result was **62** because integer division discards the fractional part. Casting the numerator to `double` produces **62.50**.

## Running the Programs

```bash
dotnet run --project Program1_Hello
dotnet run --project Program2_Profile
dotnet run --project Program3_BillSplitter
```
