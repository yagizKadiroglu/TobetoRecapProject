using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;

namespace KodlamaIoWorkshop.Business.Abstract;

public interface ICategoryService
{
    public void Add(CreateCategoryRequest createCategoryRequest);

    public void Update(UpdateCategoryRequest updateCategoryRequest);

    public void Delete(DeleteCategoryRequest deleteCategoryRequest);

    public List<GetAllCategoryResponse> GetAll();

    public GetByIdCategoryResponse GetByIdCategory(int id);
}
