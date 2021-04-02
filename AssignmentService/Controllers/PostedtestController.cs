using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentService.Controllers
{
    [Authorize]
    public class PostedtestController : ApiController
    {
        public IHttpActionResult Get()
        {
            using (ClassroomDBEntities entities = new ClassroomDBEntities())
            {
                return Ok(entities.PostedTests.ToList());
            }
        }

        public PostedTest Get(int id)
        {
            using (ClassroomDBEntities entities = new ClassroomDBEntities())
            {
                return entities.PostedTests.FirstOrDefault(e => e.ID == id);
            }
        }
        public void Post([FromBody]PostedTest postedTest)
        {
            using (ClassroomDBEntities entities = new ClassroomDBEntities())
            {
                
                entities.PostedTests.Add(postedTest);
                entities.SaveChanges();

            }
        }
    }
}
