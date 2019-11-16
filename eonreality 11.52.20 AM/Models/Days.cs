using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace eonreality.Models
{
    public class Days
    {
        [Key]
        public int DaysId {get;set;}
        public bool Day1 {get;set;}
        public bool Day2 {get;set;}
        public bool Day3 {get;set;}
        public User User {get;set;}

    }
}