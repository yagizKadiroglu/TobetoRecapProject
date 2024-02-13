using KodlamaIoWorkshop.Business.Concretes;
using KodlamaIoWorkshop.DataAccess.Concretes.InMemory;
using KodlamaIoWorkshop.Entities;

Teacher teacher1 = new Teacher(1, "Engin", "Demiroğ", "asdksakdklsl");

Category category1 = new Category(1, "Proglama");

Course course1 = new Course(1, ".NET", "yeni başlayanlar için .NET", "dslkdlkslf", true);

course1.Category = category1;

//Console.WriteLine(course1.Name);
//CourseManager courseManager = new CourseManager(new ImCourseDal());
//Console.WriteLine(courseManager.GetByIdCourse(2).Name);

CategoryManager categoryManager = new(new ImCategoryDal());
categoryManager.Delete(new KodlamaIoWorkshop.Business.Dtos.Requests.DeleteCategoryRequest { Id = 1 });

foreach (var item in categoryManager.GetAll())
{
    Console.WriteLine("{0} {1}",item.Id,item.Name);
}

categoryManager.Update(new KodlamaIoWorkshop.Business.Dtos.Requests.UpdateCategoryRequest { Id = 2, Name = "sadadaa" });

Console.WriteLine(categoryManager.GetByIdCategory(2).Name);


