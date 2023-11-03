using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidation.Models;

namespace DojoSurveyWithValidation.Controllers;

public class FormController : Controller
    
{      
    [HttpGet()]     
    [Route("")] 
    public ViewResult Index()      
    {            
    	return View();        
    }

    [HttpPost("process")]     
    public IActionResult Results(Survey surveyResults)      
    {            
        if (ModelState.IsValid)
        {
    	    return View(surveyResults);   
        }
        else
        {
            return View("Index");
        }
    }
} 

