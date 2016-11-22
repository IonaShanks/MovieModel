using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace MovieModel 
{
    public enum Certification
    {
        [Display(Name = "G")]
        G,
        [Display(Name = "PG")]
        PG,
        [Display(Name = "12")]
        Twelve,
        [Display(Name = "12A")]
        TwelveA,
        [Display(Name = "15")]
        Fifteen,
        [Display(Name = "18")]
        Eighteen
    };
    public class MovieListing
    {
        
        [Key, Required, MaxLength(10)]
        public String FilmID { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public Certification Certification { get; set; }
        [Required]
        public String Genre { get; set; }
        public String Description { get; set; }
        [Required]
        // Minutes
        public double RunTime { get; set; }

        
        public virtual List<Cinema> Cinemas { get; set; }

    }


}

