#pragma warning disable CS8618

//Allows you use a feature of C# to do validations
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models;

public class Student
{
    [Required]
    public string Name {get; set;}

    [Required]
    public string DojoLocation {get; set;}

    [Required]
    public string FavLanguage {get; set;}

    [MinLength(10, ErrorMessage = "Must have a minimum of 10 characters!")]
    public string? Comment {get; set;}


}