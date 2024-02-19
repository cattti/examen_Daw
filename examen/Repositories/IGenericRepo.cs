using System;
using examen.Models.Base;

namespace examen.Repositories
{
	public interface IGenericRepo<TEntity> where TEntity : BaseEntity
	{

        Task<List<TEntity>> GetAll();

        TEntity FindById(Guid Id);
    }
}

