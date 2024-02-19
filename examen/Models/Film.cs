using System;
using examen.Models.Base;

namespace examen.Models
{
	public class Film : BaseEntity
	{
		public string? Name { get; set; }

		public string? Gen { get; set; }

		public ICollection<Actor_Film>Actors_Films { get; set; }

	}
}

