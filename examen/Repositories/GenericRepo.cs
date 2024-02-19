using System;
using examen.Models.Base;
using examen.Data;
using Microsoft.EntityFrameworkCore;

namespace examen.Repositories
{
	public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : BaseEntity
    {

        protected readonly clasaContext _clasaContext;

        protected readonly DbSet<TEntity> _table;

        public GenericRepo(clasaContext clasaContext)
        {
            _clasaContext = clasaContext;
            _table = _clasaContext.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }


        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }

    }
}

