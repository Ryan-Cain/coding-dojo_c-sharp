// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace PortfolioI.Controllers;   
public class ContactController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("/contact")] // We will go over this in more detail on the next page
    public string Contact()        
    {            
    	return "This is my contact!";        
    }    
}

