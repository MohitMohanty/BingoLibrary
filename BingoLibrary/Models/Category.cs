﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BingoLibrary.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order Must be in the Range 1 to 100 only!!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
