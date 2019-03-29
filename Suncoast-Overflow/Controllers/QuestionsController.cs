using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Suncoast_Overflow.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {

        private DatabaseContext db;

        public QuestionsController()
        {
            this.db = new DatabaseContext();
        }
        [HttpGet]

        public ActionResult<List<Questions>> GetAllQuestions()
        {
            var results = this.db.Questions;
            return results.ToList();
        }



        [HttpPost]
        public ActionResult<Questions> AddQuestions([FromBody] Questions incomingQuestions)
        {
            var db = new DatabaseContext();
            db.Questions.Add(incomingQuestions);
            db.SaveChanges();
            return incomingQuestions;
        }

        [HttpDelete("{id}")]
        public ActionResult<Object> DeleteQuestions([FromRoute] int id)
        {
            var db = new DatabaseContext();
            var questionsToDelete = db.Questions.FirstOrDefault(questions => questions.Id == id);
            if (questionsToDelete != null)
            {
                db.Questions.Remove(questionsToDelete);
                db.SaveChanges();
                return questionsToDelete;
            }
            else
            {
                return new { message = "Question not found" };
            }
        }

    }
}