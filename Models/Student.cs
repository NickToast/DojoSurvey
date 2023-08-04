#pragma warning disable CS8618

//Allows you use a feature of C# to do validations
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models;

public class Student
{
    [Required]
    [MinLength(2, ErrorMessage = "Name must have at least 2 characters.")]
    public string Name {get; set;}

    [Required]
    public string DojoLocation {get; set;}

    [Required]
    public string FavLanguage {get; set;}

    [MinLength(20, ErrorMessage = "Must have a minimum of 20 characters!")]
    public string? Comment {get; set;}
}