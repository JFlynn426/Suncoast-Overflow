using System.Collections.Generic;
using System;

namespace SuncoastOverflow.Models
{
    public class Answers
    {
        public int Id { get; set; }

        public string AnswerBody { get; set; }

        public int AnswerVotes { get; set; }

        public DateTime AnswerCreatedTime { get; set; } = DateTime.Now;

        public string AnswerAuthor { get; set; }

        // Navigation properties

        public int QuestionId { get; set; }

        public Questions Questions { get; set; }
    }
}