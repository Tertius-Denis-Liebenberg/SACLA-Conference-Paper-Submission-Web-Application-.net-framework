using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SACLA_9205.Models
{
    public class Paper
    {
        [Key]
        public int PaperID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Abstract { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Submission Date")]
        public DateTime DateSubmitted { get; set; }

        public int TopicID { get; set; }
    }
    public class Topic
    {
        [Key]
        public int TopicID { get; set; }

        [Required]
        public string TopicName { get; set; }
    }
}