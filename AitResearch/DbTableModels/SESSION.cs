using System;
using System.ComponentModel.DataAnnotations;

namespace AitResearch.DbTableModels
{
    public class SESSION
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime DATE { get; set; }
        [Required]
        public string IP_ADDRESS { get; set; }
        [Required]
        public string GIVEN_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public DateTime BIRTHDAY { get; set; }
        public string PHONE { get; set; }
    }
}