using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is an Index Page!";
        }

        public string Hello()
        {
            return "Who's There?";
        }
    }
}
