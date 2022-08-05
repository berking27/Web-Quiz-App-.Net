using System.ComponentModel.DataAnnotations.Schema;
using QuizAPI.Models.BaseModels;

namespace QuizAPI.Models
{
    public class Participant : BaseModel
    {
        [Column(TypeName ="nvarchar(50)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public int Score { get; set; }

        public int TimeTaken { get; set; }


    }
}

