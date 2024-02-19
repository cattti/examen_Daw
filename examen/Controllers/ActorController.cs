using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using examen.Data;
using examen.Models;
using examen.DTOs;
using examen.Repositories.ActorRepo;
namespace examen.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
	{

        private readonly clasaContext _context;

        public ActorController(clasaContext context)
        {
            _context = context;
        }





        [HttpGet("ActorsByFilmId")]
        public async Task<IActionResult> GetActorsByFilmId(Guid filmId)
        {
            var actors = await _context.Actors
                .Where(a => a.Actors_Films.Any(af => af.FilmId == filmId))
                .ToListAsync();

            return Ok(actors);
        }







        [HttpPost("AssignFilms")]
        public async Task<IActionResult> AssignFilmsToActor(ActoriFilmeDto assignDTO)
        {
            var actor = await _context.Actors.Include(a => a.Actors_Films).FirstOrDefaultAsync(a => a.Id == assignDTO.ActorId);
            if (actor == null)
            {
                return NotFound("Actor not found");
            }

            foreach (var filmId in assignDTO.FilmsId)
            {
                var film = await _context.Films.FindAsync(filmId);
                if (film != null)
                {
                    actor.Actors_Films.Add(new Actor_Film { FilmId = filmId });
                }
            }

            await _context.SaveChangesAsync();

            return Ok("Films assigned");
        }







        [HttpGet("ShowActors")]
        public async Task<IActionResult> GetActors()
        {
            var actors = await _context.Actors.ToListAsync();

            return Ok(actors);
        }






        
        public IActorRepo _actorRepository;

        public ActorController(IActorRepo actorRepository)
        {
            _actorRepository = actorRepository;
        }



        [HttpGet("getActorsWithRepo")]
        public async Task<IActionResult> GetActorsWithRepo()
        {
            var actors = await _actorRepository.GetAllActorsAsync();
            return Ok(actors);
        }

    }
}

