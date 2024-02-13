using KodlamaIoWorkshop.Business.Abstract;
using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using KodlamaIoWorkshop.DataAccess.Abstract;
using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.Business.Concretes;

public class CourseManager:ICourseService
{
    ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(CreateCourseRequest createCourseRequest)
    {
        Course course = new Course();
        course.Name = createCourseRequest.Name;
        course.Id = createCourseRequest.Id;
        course.Description = createCourseRequest.Description;
        course.IsFree = createCourseRequest.IsFree;
        course.PictureUrl = createCourseRequest.PictureUrl;
        _courseDal.Add(course);
    }

    public void Delete(DeleteCourseRequest deleteCourseRequest)
    {
        Course course = _courseDal.GetById(deleteCourseRequest.Id);
        
        _courseDal.Delete(course);
    }

    public void Update(UpdateCourseRequest updateCourseRequest)
    {
        Course course = new Course();
        course.Name = updateCourseRequest.Name;
        course.Id = updateCourseRequest.Id;
        course.Description = updateCourseRequest.Description;
        course.IsFree = updateCourseRequest.IsFree;
        course.PictureUrl = updateCourseRequest.PictureUrl;
        _courseDal.Update(course);
    }
    public List<GetAllCourseResponse> GetAll()
    {
        List<GetAllCourseResponse> course = new List<GetAllCourseResponse>();
        foreach (var item in _courseDal.GetAll())
        {
            GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
            getAllCourseResponse.Name = item.Name;
            getAllCourseResponse.Id = item.Id;
            getAllCourseResponse.Description = item.Description;
            getAllCourseResponse.IsFree = item.IsFree;
            getAllCourseResponse.PictureUrl = item.PictureUrl;  
            course.Add(getAllCourseResponse);

        }

        return course;
    }

    public GetByIdCourseResponse GetByIdCourse(int id)
    {
        Course Course = _courseDal.GetById(id);

        GetByIdCourseResponse getByIdCourseResponse = new GetByIdCourseResponse();
        getByIdCourseResponse.Name = Course.Name;
        getByIdCourseResponse.Id = Course.Id;
        getByIdCourseResponse.IsFree = Course.IsFree;
        getByIdCourseResponse.Description = Course.Description;
        getByIdCourseResponse.PictureUrl = Course.PictureUrl;

        return getByIdCourseResponse;

    }

   
}

