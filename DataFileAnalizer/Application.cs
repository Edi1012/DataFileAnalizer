namespace DataFileAnalizer;

public class Application
{
    public Application(DataFileAnalizerValidator validationRules)
    {
        ValidationRules = validationRules;
    }

    public DataFileAnalizerValidator ValidationRules { get; }

    public void Run() 
    {
        try
        {
            var DataAnalizer = new DataAnalizer("C:\\Users\\edgar\\source\\repos\\Edi1012\\DataFileAnalizer\\Data.txt");
            var validation = ValidationRules.Validate(DataAnalizer);

            if(validation.IsValid == false) 
            {
                Console.WriteLine(string.Join("\n", validation.Errors));
                Console.ReadLine();
                return;
            }

            DataAnalizer.PrintResults();
            Console.ReadLine();
            return;
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
    }
}
