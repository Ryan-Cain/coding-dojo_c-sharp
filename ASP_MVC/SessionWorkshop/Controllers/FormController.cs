using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Models;

namespace SessionWorkshop.Controllers;

public class FormController : Controller
{
  [HttpGet]  
  [Route("")]
  public ViewResult EnterName()
  {
    return View("Index");
  }


  [HttpPost("process")]  
  public IActionResult Process(string name)
  {
    if (name != null)
    {
       HttpContext.Session.SetString("Name", name);
       return RedirectToAction("LoggedIn");
    }
    else
    {
        return View("Index");
    }
  }

  [HttpGet("success")]
  public IActionResult LoggedIn()
  {
    if (HttpContext.Session.GetString("Name") != null)
    {
        HttpContext.Session.SetInt32("Number", 30);
        return View("Dashboard");
    }
    else
    {
        return RedirectToAction("EnterName");
    }
  }

    [HttpGet("addOne")]
    public IActionResult AddOne()
    {
        int? Number = HttpContext.Session.GetInt32("Number");
        if (Number != null)
        {
            HttpContext.Session.SetInt32("Number", (int)(Number += 1));
        }
        return View("Dashboard");
    }

    [HttpGet("subOne")]
    public IActionResult SubOne()
    {
        int? Number = HttpContext.Session.GetInt32("Number");
        if (Number != null)
        {
            HttpContext.Session.SetInt32("Number", (int)(Number -= 1));
        }
        return View("Dashboard");
    }

    [HttpGet("timesTwo")]
    public IActionResult TimesTwo()
    {
        int? Number = HttpContext.Session.GetInt32("Number");
        if (Number != null)
        {
            HttpContext.Session.SetInt32("Number", (int)(Number *= 2));
        }
        return View("Dashboard");
    }

    [HttpGet("plusRand")]
    public IActionResult PlusRand()
    {
        int? Number = HttpContext.Session.GetInt32("Number");
        if (Number != null)
        {
            Random rand = new Random();
            HttpContext.Session.SetInt32("Number", (int)(Number += rand.Next(1,10)));
        }
        return View("Dashboard");
    }

    [HttpGet("logout")]
    public ViewResult LogOut()
    {
        HttpContext.Session.Clear();
        return View("Index");
    }
}
