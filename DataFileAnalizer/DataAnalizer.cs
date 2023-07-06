namespace DataFileAnalizer;

public class DataAnalizer
{

    public DataAnalizer(string path) 
    {
        this.path = path;
    }
    public string path              { get; set; }
    private string[] stringArray    { get; set; }
    private int[] intArray       { get; set; }


    public void PrintResults() 
    {
        stringArray = File.ReadAllLines(path);

        intArray = stringArray.Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("Total integers:" + intArray.Length);
        Console.WriteLine("Sum:" + intArray.Sum());
        Console.WriteLine("Average:" + intArray.Average());
        Console.WriteLine("Minimum:" + intArray.Min());
        Console.WriteLine("Minimum:" + intArray.Max());
    }



}
