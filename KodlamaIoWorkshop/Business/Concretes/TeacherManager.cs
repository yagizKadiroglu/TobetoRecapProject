using KodlamaIoWorkshop.Business.Abstract;
using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using KodlamaIoWorkshop.DataAccess.Abstract;
using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.Business.Concretes;

public class TeacherManager : ITeacherService
{
    ITeacherDal _teacherDal;

    public TeacherManager(ITeacherDal teacherDal)
    {
        _teacherDal = teacherDal;
    }
    public void Add(CreateTeacherRequest createTeacherRequest)
    {
        Teacher teacher = new Teacher();
        teacher.FirstName = createTeacherRequest.FirstName;
        teacher.Id = createTeacherRequest.Id;
        teacher.LastName = createTeacherRequest.LastName;
        teacher.ImageURL = createTeacherRequest.ImageUrl;
        _teacherDal.Add(teacher);
    }

    public void Delete(DeleteTeacherRequest deleteTeacherRequest)
    {
        Teacher teacher = _teacherDal.GetById(deleteTeacherRequest.Id);
        
        _teacherDal.Delete(teacher);
    }

    public void Update(UpdateTeacherRequest updateTeacherRequest)
    {
        Teacher teacher = new Teacher();
        teacher.FirstName = updateTeacherRequest.FirstName;
        teacher.Id = updateTeacherRequest.Id;
        teacher.LastName= updateTeacherRequest.LastName;
        teacher.ImageURL = updateTeacherRequest.ImageUrl;
        _teacherDal.Update(teacher);
    }
    public List<GetAllTeacherResponse> GetAll()
    {
        List<GetAllTeacherResponse> teacher = new List<GetAllTeacherResponse>();
        foreach (var item in _teacherDal.GetAll())
        {
            GetAllTeacherResponse getAllTeacherResponse = new GetAllTeacherResponse();
            getAllTeacherResponse.FirstName = item.FirstName;
            getAllTeacherResponse.Id = item.Id;
            getAllTeacherResponse.LastName = item.LastName;
            getAllTeacherResponse.ImageUrl = item.ImageURL;
            
            teacher.Add(getAllTeacherResponse);

        }

        return teacher;
    }

    public GetByIdTeacherResponse GetByIdTeacher(int id)
    {
        Teacher teacher = _teacherDal.GetById(id);

        GetByIdTeacherResponse getByIdTeacherResponse = new GetByIdTeacherResponse();
        getByIdTeacherResponse.FirstName = teacher.FirstName;
        getByIdTeacherResponse.Id = teacher.Id;
        getByIdTeacherResponse.LastName = teacher.LastName;
        getByIdTeacherResponse.ImageUrl = teacher.ImageURL;

        return getByIdTeacherResponse;

    }

    
}
