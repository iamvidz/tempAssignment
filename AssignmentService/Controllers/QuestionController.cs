using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentService.Controllers
{
    [Authorize]
    public class QuestionController : ApiController
    {
        public IEnumerable<Question> Get()
        {
            using(ClassroomDBEntities entities = new ClassroomDBEntities())
            {
                return entities.Questions.ToList();
            }
        }

        public void Post( Question question)
        {
            using (ClassroomDBEntities entities = new ClassroomDBEntities())
            {
                entities.Questions.Add(question);
                entities.SaveChanges();

                
            }
        }
    }
}
