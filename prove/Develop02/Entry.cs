
public class Entry
{
    //Attributes
    public string _date;
    public string _prompt;
    public string _response;

    //Methods

    public Entry(string dateParam, string promptParam, string responseParam)
    {
            
    }
    public string getDate()
    {
        DateTime today = DateTime.Today;

        string date = today.ToString("MM/dd/yyyy");
        return date;
    }

    public string getUserResponse(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        return response;
    }
}