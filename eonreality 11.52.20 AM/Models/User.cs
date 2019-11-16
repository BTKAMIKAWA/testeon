using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace eonreality.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MaxLength(30)]
        public string NameField {get;set;}

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string EmailField {get;set;}

        [Required]
        public string Gender {get;set;}

        [Required]
        public DateTime DateRegistered {get;set;}

        

        [MaxLength(100)]
        public string AdditionalR {get;set;}

    }
}