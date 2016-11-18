using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MovieModel
{
    public class Cinema
    {
        [Key]
        public int CinemaID { get; set; }
        public String Name { get; set; }
        [Url]
        public String Website { get; set; }
        public String PhoneNumber { get; set; }
        public String TicketPrice { get; set; }
        public double RunTime { get; set; }
    }

    //public class MovieContext : DbContext
    //{
    //    public MovieContext() : base("DefaultConnection")
    //    {

    //    }
    //    public DbSet<Cinema> Cinemas { get; set; }
    //}


}
