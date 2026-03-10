using System;

public class job
{
    public string _jobTitle;
    public string _company;
    public string _startyear;
    public string _endyear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear} - {_endyear}");
    }
}