using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers;

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
    	return View(surveyResults);   
    }

    // [HttpGet()]     
    // [Route("results")] 
    // public ViewResult Results()      
    // {           
    // 	return View();        
    // }     
} 

