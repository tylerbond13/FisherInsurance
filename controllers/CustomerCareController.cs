using Microsoft.AspNetCore.Mvc; 

[Route("customer")]

public class CustomerCareController : Controller 
{
    [Route("index")]
    public IActionResult Index() 
    { 
        return Ok("This is the index of the CustomerCareController"); 
        
    } 
    [Route("claims")]
    public IActionResult Claims()
    {
        return Ok("This is the claims of the CustomerCareController"); 
    }

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This is the page to file a claim for the CustomerCareController"); 
    }

    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This is the page to check their claim status for the CustomerCareController"); 
    }
}