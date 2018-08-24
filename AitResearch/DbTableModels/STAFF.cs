using System.ComponentModel.DataAnnotations;

namespace AitResearch.DbTableModels
{
    public class STAFF
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string USERNAME { get; set; }
        [Required]
        public string PASSWORD { get; set; }
    }
}