using System;
class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response) //formats the entries
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public Entry(string prompt, string response, DateTime date) //formats the entries using DataTime
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}