using System.Security.Cryptography;
using lab3;

MadScientist madScientistOne = new MadScientist() 
{ 
    FirstName = "Victor", // EF Core assigns ID
    LastName = "Frankenstein",
    Age = 19, 
    LastSeen =  DateTime.Parse("1/23/2020")
};

// Using AppDbContext class in DbContext.cs to communicate with database- Logs into database
using ( var db = new AppDbContext()) 
{
    if (db.Database.EnsureCreated()) // Returns true if database D.N.E and then creates it, otherwise returns false and continues
    {
        db.Add(madScientistOne); // Adds an object madScientistOne to the database
        db.SaveChanges(); // Saves changes to the database
    }
}

/*
using ( var db = new AppDbContext())
{
    foreach (MadScientist m in db.MadScientists)
    {
        Console.WriteLine($"{m.MadScientistID} - {m.FirstName} {m.LastName}");
    }
}
*/