using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WeeklyAssignment.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeeklyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>

        private static List<Employee> EmployeeList = new List<Employee>
        {
            new Employee {Id=1, name = "rance", age = 25},
            new Employee {Id=2, name = "aubry", age = 23},
            new Employee {Id=3, name = "canete", age = 24},
        };
        [HttpGet]
        public IEnumerable<Employee> Get()
        {

            return EmployeeList;
        }

        // GET api/<EmployeeController>/5
       [HttpGet("{name}")]
        public string Get(String name)
        {
            var isExist = EmployeeList.Find(EmployeeTemp => EmployeeTemp.name == name);

            if (isExist != null)
            {
                try
                {
                    return "You are " + name;
                }
                catch (HttpRequestException)
                {

                    return "Something weng wrong";
                }
            }
            return "Name not found in the record";
        }


        // POST api/<EmployeeController>
        [HttpPost]
        public string Post([FromBody] Employee paramss)
        {
            var isExist = EmployeeList.Find((EmployeeTemp) => EmployeeTemp.name == paramss.name);

            if (isExist != null)
            {
                try
                {
                    return "You are " + paramss.name;
                }
                catch (HttpRequestException)
                {

                    return "Something weng wrong";
                }
            }
            return "Name not found in the record";
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string name)
        {
            var isExist = EmployeeList.Find((EmployeeTemp) => EmployeeTemp.Id == id);

            if (isExist != null)
            {
                isExist.name = name;
                return "Successfully Updated";
            }
            else
            {
                return "ID not found";
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var isExist = EmployeeList.Find((EmployeeTemp) => EmployeeTemp.Id == id);

            if (isExist != null)
            {
                EmployeeList.Remove(isExist);
                return "Successfully Updated";
            }
            else
            {
                return "ID not found";
            }
        }
    }
}
