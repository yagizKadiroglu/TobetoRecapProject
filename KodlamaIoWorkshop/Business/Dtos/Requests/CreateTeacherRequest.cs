﻿namespace KodlamaIoWorkshop.Business.Dtos.Requests;

public class CreateTeacherRequest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
}
