using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCRSProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        [Display(Name = "Date Published")]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime PublishedDate { get; set; }

        
        

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}