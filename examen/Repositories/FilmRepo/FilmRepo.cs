using System;
using examen.Data;
using Microsoft.EntityFrameworkCore;
using examen.Models;

namespace examen.Repositories.FilmRepo
{
	public class FilmRepo : IFilmRepo
	{
        private readonly clasaContext _context;

        public FilmRepo(clasaContext context)
        {
            _context = context;
        }

        public async Task<List<Film>> GetAllFilmsAsync()
        {
            return await _context.Films.ToListAsync();
        }
    }
}

