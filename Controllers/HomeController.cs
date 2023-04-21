using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.Chrome;

namespace WebApplication3.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("chromedriver")]
        public IActionResult Test()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            using (var driver = new ChromeDriver(chromeOptions))
            {
                driver.Navigate().GoToUrl("https://www.google.com");
            }
            return Ok();
        }
    }
}