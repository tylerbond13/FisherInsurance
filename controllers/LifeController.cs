using Microsoft.AspNetCore.Mvc; 
public class LifeController : Controller 
{
  
    public IActionResult Index() 
    { 
        return View();
        
        //return Ok("This is the index of the LifeController"); 
        
    } 
    
    public IActionResult Quote()
    {
        return View();
        
        //return Ok("This is the quote of the LifeController"); 
    }
}