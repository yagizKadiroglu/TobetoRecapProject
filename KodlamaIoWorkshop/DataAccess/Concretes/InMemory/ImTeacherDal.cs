using KodlamaIoWorkshop.DataAccess.Abstract;
using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.DataAccess.Concretes.InMemory;

public class ImTeacherDal : ITeacherDal
{
    List<Teacher> _teacher = new List<Teacher>();

    public ImTeacherDal()
    {
        _teacher.Add(new Teacher(1, "engin", "demiroğ", "skdldksf")) ;
        _teacher.Add(new Teacher(2, "irem", "balcı", "skdldsadaf"));
        _teacher.Add(new Teacher(3, "halit enes", "kalaycı", "asasdksf"));
    }
    public void Add(Teacher teacher)
    {
        _teacher.Add(teacher);
    }

    public void Delete(Teacher teacher)
    {
        _teacher.Remove(teacher);
    }

    public List<Teacher> GetAll()
    {
       return _teacher;
    }

    public Teacher GetById(int id)
    {
        return _teacher.Find(p => p.Id == id);
    }

    public void Update(Teacher teacher)
    {
        Teacher teacherToUpdate = _teacher.FirstOrDefault(c => c.Id == teacher.Id);
        if (teacherToUpdate != null)
        {
            teacherToUpdate.FirstName = teacher.FirstName;
            teacherToUpdate.LastName = teacher.LastName;
            teacherToUpdate.ImageURL = teacher.ImageURL;
        }
    }
}
