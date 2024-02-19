using System;
using examen.Data;
using Microsoft.EntityFrameworkCore;
using examen.Models;
using examen.Repositories;

namespace examen.Repositories.ActorRepo
{
	public class ActorRepo : IActorRepo
    {
        private readonly clasaContext _context;

        public ActorRepo(clasaContext context)
        {
            _context = context;
        }

        public async Task<List<Actor>> GetAllActorsAsync()
        {
            return await _context.Actors.ToListAsync();
        }


    }
}

