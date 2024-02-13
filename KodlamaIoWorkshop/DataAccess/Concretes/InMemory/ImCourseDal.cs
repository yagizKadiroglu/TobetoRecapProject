using KodlamaIoWorkshop.DataAccess.Abstract;
using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.DataAccess.Concretes.InMemory;

public class ImCourseDal : ICourseDal
{
    List<Course> _courses = new List<Course>();

    public ImCourseDal()
    {
        _courses.Add(new Course(1, ".NET", "SDJSKF", "WWssk", true));
        _courses.Add(new Course(2, "JAVA", "SDJSKF", "ssAAk", true));
        _courses.Add(new Course(3, "JAVASCRİPT", "SDJSKF", "aasSSk", true));

    }
    public void Add(Course course)
    {
       _courses.Add(course);
    }

    public void Delete(Course course)
    {
        _courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course GetById(int id)
    {
        return _courses.Find(p => p.Id == id);
    }

    public void Update(Course course)
    {

       Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.PictureUrl = course.PictureUrl;
            courseToUpdate.IsFree = course.IsFree;
            
        }
    }
}
