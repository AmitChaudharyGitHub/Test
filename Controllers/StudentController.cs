using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController :ControllerBase
    {

        
        private readonly int a;

        public StudentController()
        {
        }

        public string Get(){
            return "Hello World";
        }
    }
}