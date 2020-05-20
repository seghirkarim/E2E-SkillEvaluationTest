using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E2E_SkillEvaluationTest.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public Todo()
        {

        }
    }
}
