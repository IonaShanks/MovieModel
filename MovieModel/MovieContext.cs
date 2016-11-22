using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModel
{

    
    public class MovieContext : DbContext
    {
        public MovieContext() : base("Movie Project")
        {

        }
        public DbSet<MovieListing> Listings { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }

    
}
