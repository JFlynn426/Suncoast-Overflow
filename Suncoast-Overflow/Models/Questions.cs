using System.Collections.Generic;
using System;

namespace SuncoastOverflow.Models
{
    public class Questions
    {
        public int Id { get; set; }

        public string QuestionTitle { get; set; }

        public string QuestionBody { get; set; }

        public int QuestionVotes { get; set; }

        public DateTime QuestionCreatedTime { get; set; } = DateTime.Now;

        public string QuestionAuthor { get; set; }

        public List<Answers> Answer { get; set; } = new List<Answers>();

    }
}