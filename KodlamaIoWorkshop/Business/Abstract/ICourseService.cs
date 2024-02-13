using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;

namespace KodlamaIoWorkshop.Business.Abstract;
public interface ICourseService
{
    public void Add(CreateCourseRequest createCourseRequest);

    public void Update(UpdateCourseRequest updateCourseRequest);

    public void Delete(DeleteCourseRequest deleteCourseRequest);

    public List<GetAllCourseResponse> GetAll();

    public GetByIdCourseResponse GetByIdCourse(int id);
}
