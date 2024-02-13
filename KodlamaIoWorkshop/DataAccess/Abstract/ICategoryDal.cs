using KodlamaIoWorkshop.Entities;

namespace KodlamaIoWorkshop.DataAccess.Abstract;

public interface ICategoryDal
{
    public void Add(Category category);
    public void Delete(Category category);
    public void Update(Category category);

    public List<Category> GetAll();

    public Category GetById(int id);
}
