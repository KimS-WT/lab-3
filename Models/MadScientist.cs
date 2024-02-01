using System;

namespace lab3 // allows DbContext to "Find" MadScientist class to be used as entity
{
    public class MadScientist
    {
        public int MadScientistID {get;set;} // Primary Key
        public string? FirstName {get;set;} // "?" = optional
        public string? LastName {get;set;} // optional
        public int Age {get;set;}
        public DateTime LastSeen {get;set;} //Date&Time Mad Scientist was last seen
    }
}