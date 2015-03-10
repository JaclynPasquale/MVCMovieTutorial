using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMovieTutorial.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public string ApplicationUserID { get; set; }
        public int Stars { get; set; }

        public virtual Movie Movie { get; set; }
        
    }

    public class RatingDBContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }
    }
}