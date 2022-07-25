using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuizAPI.Models.BaseModels;

namespace QuizAPI.Models
{
    public class Question : BaseModel
    {
        
        [Column(TypeName ="nvarchar(250)")]
        public string InWords { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? ImageName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option1 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option2 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option3 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Option4 { get; set; }

        public int Answer { get; set; }

    }
}

