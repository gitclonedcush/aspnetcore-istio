using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GradesService.Models;

namespace GradesService.Controllers
{
    [Route("api/[controller]")]
    public class GradesController : Controller
    {
        private Grade studentGradeOne;
        private Grade studentGradeTwo;

        public GradesController()
        {
            studentGradeOne = new Grade();
            studentGradeOne.Name = "Daniel Cushing";
            studentGradeOne.Score = 97.0;
            studentGradeOne.Percentile = 99.0;

            studentGradeTwo = new Grade();
            studentGradeTwo.Name = "Luke Skywalker";
            studentGradeTwo.Score = 85.0;
            studentGradeTwo.Percentile = 90.0;
        }

        /// <summary>
        /// Gets student grades 
        /// </summary>
        [HttpGet]
        public IEnumerable<double> Get()
        {
            return new double[] { studentGradeOne.Score, studentGradeTwo.Score };
        }

        // GET api/grades/5
        [HttpGet("{id}")]
        public double Get(int id)
        {
            return studentGradeOne.Score;
        }

        // POST api/grades
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/grades/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/grades/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}