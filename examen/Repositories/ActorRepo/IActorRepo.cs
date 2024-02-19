using System;
using examen.Repositories;
using examen.Models;

namespace examen.Repositories.ActorRepo
{
    public interface IActorRepo
    {

        //Task<Actor> FindByMovie(string movie);


        //Task<List<Actor>> FindById();


        Task<List<Actor>> GetAllActorsAsync();

    }
}

