using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace MvcMovie.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }        
        
        public DbSet<Movie> Movies {get;set;}
        public DbSet<Booking> Bookings {get;set;}

    }


    public class Movie{
        public int MovieID{get;set;}
        public string Title{get;set;}
        public decimal TicketPrice{get;set;}
        public List<Booking> Bookings{get;set;}
    }
    public class Booking{
        public int BookingID{get;set;}
        public string CustomerName{get;set;}
        public int Quantity{get;set;}
        public decimal TotalPrice{get;set;}
        public Movie Movie{get;set;}
    }
}