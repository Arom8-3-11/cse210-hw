using System; // this starts up the program from what I can tell

public class Job //"public" is an access modifier for type/members      
//class is a data type defining attributes/methods
//this is kind of like css in which you can use a class holding several different things like div
{
    public string _jobTitle; //this is a member variable 
    // note to self, when adding a member variable, make sure to add the modifier and string so that the class will work
    public string _company;
    public int _startYear;
    public int _endYear;




    public void Display() 
    //start with capital letter, should not have any parameters and shouldn't return anything
    // hence using void will allow that to happen.

    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}}-{_endYear}");

    }
}