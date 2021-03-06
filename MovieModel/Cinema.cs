﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MovieModel
{
    public class Cinema
    {
        [Key]
        public String CinemaID { get; set; }
        public String Name { get; set; }
        [Url]
        public String Website { get; set; }
        public String PhoneNumber { get; set; }
        public String TicketPrice { get; set; }
        


        public String MovieID { get; set; }
        public virtual Movie Movies { get; set; }
    }

    


}
