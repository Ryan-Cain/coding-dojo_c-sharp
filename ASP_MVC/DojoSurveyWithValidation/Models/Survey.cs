#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models;
public class Survey
{
    [Required(ErrorMessage ="Name is required!")]
    [MinLength(2, ErrorMessage ="Name must be at least two characters!")]
    public string Name {get;set;}

    [Required(ErrorMessage ="Error Message is required!")]
    public string Location {get;set;}

    [Required(ErrorMessage ="Favorite Language is required!")]
    public string FavoriteLanguage {get;set;}

    [MinLength(21)]
    public string Comment {get;set;}
}