using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Controllers
{
    public class MoviesController:Controller
    {
        private readonly MovieContext _context;
        public MoviesController(MovieContext context){
            _context = context;
        }
        public async Task<IActionResult> Details(int? id)
        {
            Movie movie = null;

            if(id==null)
            {
                return NotFound();
            }

            
            movie = await _context.Movies
            .SingleOrDefaultAsync(m => m.MovieID == id);
            

            if(movie == null)
            {
                return NotFound();
            }

            return View(movie);
            
        }

    }
}