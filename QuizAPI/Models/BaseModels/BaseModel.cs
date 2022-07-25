using System;
using System.ComponentModel.DataAnnotations;

namespace QuizAPI.Models.BaseModels
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }

    }
}

