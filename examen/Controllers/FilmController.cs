using System;
using examen.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examen.Data;
using examen.Models;
using examen.Repositories.FilmRepo;


namespace examen.Controllers
{
    public class FilmController : ControllerBase
    {
        private readonly clasaContext _context;

        public FilmController(clasaContext context)
        {
            _context = context;
        }

        [HttpGet("ShowFilms")]
        public async Task<IActionResult> GetFilms()
        {
            var films = await _context.Films.ToListAsync();

            return Ok(films);
        }




        private readonly IFilmRepo _filmRepository;

        public FilmController(IFilmRepo filmRepository)
        {
            _filmRepository = filmRepository;
        }

        [HttpGet("getFilmsWithRepo")]
        public async Task<IActionResult> GetFilmsWithRepo()
        {
            var films = await _filmRepository.GetAllFilmsAsync();
            return Ok(films);
        }


    }
}

