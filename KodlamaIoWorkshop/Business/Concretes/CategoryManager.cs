using KodlamaIoWorkshop.Business.Abstract;
using KodlamaIoWorkshop.Business.Dtos.Requests;
using KodlamaIoWorkshop.Business.Dtos.Responses;
using KodlamaIoWorkshop.DataAccess.Abstract;
using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.Business.Concretes;

public class CategoryManager:ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }
    public void Add(CreateCategoryRequest createCategoryRequest)
    {
        Category category = new Category();
        category.Name = createCategoryRequest.Name;
        category.Id = createCategoryRequest.Id;
        _categoryDal.Add(category);
    }

    public void Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category category = _categoryDal.GetById(deleteCategoryRequest.Id);

        _categoryDal.Delete(category);
    }

    public void Update(UpdateCategoryRequest updateCategoryRequest)
    {
        Category category = new Category();
        category.Name = updateCategoryRequest.Name;
        category.Id = updateCategoryRequest.Id;

        _categoryDal.Update(category);
    }
    public List<GetAllCategoryResponse> GetAll()
    {
        List<GetAllCategoryResponse> category = new List<GetAllCategoryResponse>();
        foreach (var item in _categoryDal.GetAll())
        {
            GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
            getAllCategoryResponse.Name = item.Name;
            getAllCategoryResponse.Id = item.Id;
            category.Add(getAllCategoryResponse);
        }

        return category;
    }

    public GetByIdCategoryResponse GetByIdCategory(int id)
    {
        Category category = _categoryDal.GetById(id);

        GetByIdCategoryResponse getByIdCategoryResponse = new GetByIdCategoryResponse();

        getByIdCategoryResponse.Name = category.Name;

        getByIdCategoryResponse.Id= category.Id;

        return getByIdCategoryResponse;

    }

   
}
