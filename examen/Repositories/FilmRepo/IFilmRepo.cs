using System;
using examen.Models;

namespace examen.Repositories.FilmRepo
{
	public interface IFilmRepo
	{
        Task<List<Film>> GetAllFilmsAsync();
    }
}

