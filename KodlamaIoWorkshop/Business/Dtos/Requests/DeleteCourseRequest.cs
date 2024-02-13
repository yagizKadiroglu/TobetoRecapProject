namespace KodlamaIoWorkshop.Business.Dtos.Requests;

public class DeleteCourseRequest
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsFree { get; set; }

    public string PictureUrl { get; set; }
}
