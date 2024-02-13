using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.DataAccess.Abstract;

public interface ITeacherDal
{
    public void Add(Teacher teacher);
    public void Delete(Teacher teacher);
    public void Update(Teacher teacher);

    public List<Teacher> GetAll();

    public Teacher GetById(int id);
}
