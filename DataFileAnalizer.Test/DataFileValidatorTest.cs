using DataFileAnalizer;
using FluentAssertions;

namespace FileAnalyzer.Tests
{
    public class AnalizerValidatorTests
    {
        [Fact]
        public void Validate_WithNonExistingFile_ShouldHaveErrorForPath()
        {
            // Arrange
            var data = new DataAnalizer("FileNoExiste.txt");
            var validator = new DataFileAnalizerValidator();

            // Act
            var result = validator.Validate(data);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().HaveCount(1);
            result.Errors[0].ErrorMessage.Should().Be("The file does not exist");
        }

        [Fact]
        public void Validate_WithEmptyStringData_ShouldHaveErrorForStringData()
        {
            // Arrange
            //var data = new Data(@"data_empty.txt");
            var data = new DataAnalizer("C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\DataEmpty.txt");
            var validator = new DataFileAnalizerValidator();

            // Act
            var result = validator.Validate(data);

            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().HaveCount(1);
            result.Errors[0].ErrorMessage.Should().Be("File is empty");
        }

        [Fact]
        public void Validate_WithNonIntegerStringData_ShouldHaveErrorForStringData()
        {
            // Arrange
            var data = new DataAnalizer("C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\DataInvalid.txt");
            var validator = new DataFileAnalizerValidator();

            // Act
            var result = validator.Validate(data);

            // Assert
            // Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().HaveCount(1);
            result.Errors[0].ErrorMessage.Should().Be("All data must be integer numbers");
        }

        [Fact]
        public void Print_WithValidData_WritesExpectedOutput()
        {
            // Arrange
            var data = new DataAnalizer("C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\Data.txt");
            var expectedOutput = "Total integers: 4\r\n" +
                                 "Sum: 25\r\n" +
                                 "Average: 6.25\r\n" +
                                 "Maximum: 10\r\n" +
                                 "Minimum: 2\r\n";

            // Act
            var output = CaptureConsoleOutput(() => data.PrintResults());

            // Assert
            output.Should().Be(expectedOutput);
        }

        // Helper method to capture console output
        private string CaptureConsoleOutput(Action action)
        {
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);

                action();

                return writer.ToString();
            }
        }
    }
}