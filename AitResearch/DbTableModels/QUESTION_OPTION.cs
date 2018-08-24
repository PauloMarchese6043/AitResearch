using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AitResearch.DbTableModels
{
    public class QUESTION_OPTION
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string TEXT { get; set; }

        [ForeignKey("QUESTION")]
        public int QUESTION_ID { get; set; }
        [Required]
        public QUESTION QUESTION { get; set; }

        [ForeignKey("NEXT_QUESTION")]
        public int? NEXT_QUESTION_ID { get; set; }
        public QUESTION NEXT_QUESTION { get; set; }
    }
}