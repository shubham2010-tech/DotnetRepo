﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.WEB.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        // Identity Column
        [Display(Name = "Category ID")]              
        // Label on the UI

        public int CategoryId { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty!")]
        [Column(TypeName ="varchar(50)")]
        [Display(Name = "Name of the Category")] // Label on the UI
        [StringLength(50)]

        public string CategoryName { get; set; }

        #region Navigation Properties to the Book Model

        public ICollection<Book> Books { get; set; }

        #endregion
    }
}
