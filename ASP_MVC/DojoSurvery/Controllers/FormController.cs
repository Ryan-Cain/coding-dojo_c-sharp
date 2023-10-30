// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace DojoSurvery.Controllers;   
public class FormController : Controller    
{      
    [HttpGet()]     
    [Route("")] 
    public ViewResult Index()      
    {            
    	return View();        
    }

    [HttpPost("process")]     
    // [Route("processform")]
    public ViewResult Process(string Name, string Location, string FavoriteLanguage, string Comment)      
    {            
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.FavoriteLanguage = FavoriteLanguage;
        ViewBag.Comment = Comment;
        // Console.WriteLine($"Name is {Name}");
    	return View("results");        
    }  

    [HttpGet()]     
    [Route("results")] 
    public ViewResult Results()      
    {           
    	return View();        
    }     
}