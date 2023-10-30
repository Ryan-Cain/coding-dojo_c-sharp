// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioI.Controllers;   
public class ProjectsController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("/projects")] // We will go over this in more detail on the next page
    public string Projects()        
    {            
    	return "These are my projects!";        
    }    
}

