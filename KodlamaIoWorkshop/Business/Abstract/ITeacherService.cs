using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;

namespace KodlamaIoWorkshop.Business.Abstract;

public interface ITeacherService
{
    public void Add(CreateTeacherRequest createTeacherRequest);

    public void Update(UpdateTeacherRequest updateTeacherRequest);

    public void Delete(DeleteTeacherRequest deleteTeacherRequest);

    public List<GetAllTeacherResponse> GetAll();

    public GetByIdTeacherResponse GetByIdTeacher(int id);
}
