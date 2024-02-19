using System;
namespace examen.DTOs
{
	public class ActoriFilmeDto
	{

		public Guid ActorId { get; set; }

		public List<Guid> FilmsId { get; set; }
		
	}
}

