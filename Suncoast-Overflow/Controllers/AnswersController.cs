using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Suncoast_Overflow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private DatabaseContext db;

        public AnswersController()
        {
            this.db = new DatabaseContext();
        }

        [HttpGet]
        public ActionResult<List<Answers>> GetAllAnswers()
        {
            var results = this.db.Answers;
            return results.ToList();
        }

        [HttpPost]
        public ActionResult<Answers> AddAnswers([FromBody] Answers incomingAnswers)
        {
            var db = new DatabaseContext();
            db.Answers.Add(incomingAnswers);
            db.SaveChanges();
            return incomingAnswers;
        }

        [HttpDelete("{id}")]
        public ActionResult<Object> DeleteAnswers([FromRoute] int id)
        {
            var db = new DatabaseContext();
            var answersToDelete = db.Answers.FirstOrDefault(answers => answers.Id == id);
            if (answersToDelete != null)
            {
                db.Answers.Remove(answersToDelete);
                db.SaveChanges();
                return answersToDelete;
            }
            else
            {
                return new { message = "Answer not found" };
            }
        }
    }
}