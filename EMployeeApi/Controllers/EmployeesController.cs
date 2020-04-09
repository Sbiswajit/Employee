using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class EmployeesController : ControllerBase
    {
        static List<Employee> emps = new List<Employee>()
        {
            new Employee(){Eid=1,Name="Biswajit",sal=34000,Designation="Devloper"},
             new Employee(){Eid=2,Name="Subrat",sal=30000,Designation="coder"},
              new Employee(){Eid=3,Name="Dev",sal=54000,Designation="Analyst"},
               new Employee(){Eid=4,Name="Devid",sal=3000,Designation="tester"},
                new Employee(){Eid=5,Name="Kk",sal=34000,Designation="Devloper"},
        };
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return emps;
        }
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return emps[id];
        }
    }
}