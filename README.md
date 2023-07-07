# DataFileAnalyzer

This coding challenge involves creating a C# console application that reads a file named data.txt. The file contains a list of integers, with one integer per line. The application is designed to perform the following tasks:

operations:
● Calculate the total number of integers in the file.
● Calculate the sum of all the integers in the file.
● Calculate the average of all the integers in the file.
● Find the maximum and minimum values in the file.

## Requirements

- .NET Core SDK 7.0
- The file data.txt should be located in the same directory as the executable.
- Assume that the file contains valid integers, one per line.
- Your program should handle cases where the file is empty or does not exist.
- Display the calculated results in the console output

## Installation

1. Clone the repository or download the ZIP file.
2. Open the project in your preferred development environment.
3. Restore the required NuGet packages.
4. Build the project.
5. To set the environment variable, open the Program.cs file in your project and add the following code snippet before the CreateHostBuilder method:
   Replace "C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\" with the desired file path.

## Environment Variable Configuration

The project can be configured using environment variables. Follow the instructions below to set the environment variable for the main application and the tests:

### Configuration in the Main Application

To set the environment variable in the main application, follow these steps:

1. Open the `Program.cs` file located in the project root.
2. Before the `CreateHostBuilder` method, add the following code:

```csharp
Environment.SetEnvironmentVariable("DATA_FILE_PATH", "C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\");
```

Replace `"C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\"` with the desired file path.

### Configuration in Tests

To set the environment variable in the tests, follow these steps:

1. Open the `DataFileValidatorTest.cs` file located at `...\DataFileAnalizer\DataFileAnalizer.Test\DataFileValidatorTest.cs`.
2. Find the line where the environment variable is set, which should be at line 12.
3. Update the line to set the `DATA_FILE_PATH` environment variable as follows:

```csharp
Environment.SetEnvironmentVariable("DATA_FILE_PATH", "C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\");
```

Replace `"C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\"` with the desired file path.


## Contact

If you have any questions or suggestions regarding this project, you can contact me through edi.rosuna@gmail.com.
