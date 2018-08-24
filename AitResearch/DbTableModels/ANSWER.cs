using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AitResearch.DbTableModels
{
    public class ANSWER
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string TEXT { get; set; }

        [ForeignKey("SESSION")]
        public int SESSION_ID { get; set; }
        public SESSION SESSION { get; set; }

        [ForeignKey("QUESTION")]
        public int QUESTION_ID { get; set; }
        public QUESTION QUESTION { get; set; }

        [ForeignKey("QUESTION_OPTION")]
        public int? QUESTION_OPTION_ID { get; set; }
        public QUESTION_OPTION QUESTION_OPTION { get; set; }
    }
}