using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace MovieModel 
{
    public enum Certification
    {
        [Display(Name = "G")]
        IFCOG,
        [Display(Name = "PG")]
        IFCOPG,
        [Display(Name = "12A")]
        IFCO12A,
        [Display(Name = "15A")]
        IFCO15A,
        [Display(Name = "16")]
        IFCO16,
        [Display(Name = "18")]
        IFCO18
    };

    public enum Genre
    {
        Horror,
        Comedy,
        Fantasy,
        Action,        
        Family,        
        Romance
    };

    public class Movie
    {
        
        [Key, Required, MaxLength(10)]
        public String MovieID { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public Certification Certification { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public String Description { get; set; }
        [Required]
        // Minutes
        public double RunTime { get; set; }
        public double ShowTime
        {
            get { return 20.00; }
        }

        
        public virtual List<Cinema> Cinemas { get; set; }

    }


}

