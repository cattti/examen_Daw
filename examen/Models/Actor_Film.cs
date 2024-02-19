using System;
namespace examen.Models
{
	public class Actor_Film
	{
		public Guid ActorId { get; set; }
		public Actor Actor { get; set; }

		public Guid FilmId { get; set; }
		public Film Film { get; set; }
	}
}

