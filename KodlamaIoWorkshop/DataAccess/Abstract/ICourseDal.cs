using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.DataAccess.Abstract;

public interface ICourseDal
{
    public void Add(Course course);
    public void Delete(Course course);
    public void Update(Course course);

    public List<Course> GetAll();

    public Course GetById(int id);

}
