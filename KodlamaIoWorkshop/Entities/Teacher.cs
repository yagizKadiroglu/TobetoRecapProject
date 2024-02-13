namespace KodlamaIoWorkshop.Entities;

public class Teacher

{
    public Teacher()
    {
        
    }

    public Teacher(int ıd, string firstName, string lastName, string ımageURL)
    {
        Id = ıd;
        FirstName = firstName;
        LastName = lastName;
        ImageURL = ımageURL;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string ImageURL { get; set; }

    public List<Course> Courses { get; set; }

}

