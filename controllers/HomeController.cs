using Microsoft.AspNetCore.Mvc; 
public class HomeController : Controller 
{
    public IActionResult Index() 
    { 
        return View();

        //return Ok("This is the index of the HomeController"); 
        
    } 
}